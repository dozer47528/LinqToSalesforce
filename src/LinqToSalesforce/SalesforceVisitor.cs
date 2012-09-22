using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using LinqToSalesforce.Entity;
using LinqToSalesforce.Helper;

namespace LinqToSalesforce
{
    public class SalesforceVisitor : ExpressionVisitor
    {
        public QueryTypeEnum QueryType = QueryTypeEnum.List;
        protected List<string> WhereExpression = new List<string>();
        protected List<string> OrderByExpression = new List<string>();
        protected List<string> SelectByExpression = new List<string>();
        protected Type ElementType;
        protected int? limit;
        protected int Limit
        {
            get { return limit ?? 0; }
            set { if (limit == null) limit = value; }
        }
        protected SelectTypeEnum SelectType;

        public SalesforceVisitor() { }
        public SalesforceVisitor(SelectTypeEnum selectType)
        {
            SelectType = selectType;
        }

        internal string Translate(Expression expression)
        {
            this.Visit(expression);
            return Translate();
        }

        private string Translate()
        {
            var sb = new StringBuilder();
            string selectString;
            if (QueryType == QueryTypeEnum.Any || QueryType == QueryTypeEnum.Count)
            {
                selectString = "COUNT()";
            }
            else
            {
                TranslateSelect();
                selectString = string.Join(",", SelectByExpression.ToArray());
            }
            sb.AppendFormat("SELECT {0} FROM {1}", selectString, ElementType.Name);
            if (WhereExpression.Any())
            {
                sb.AppendFormat(" WHERE {0}", string.Join(" AND ", WhereExpression.ToArray()));
            }
            if (OrderByExpression.Any())
            {
                sb.AppendFormat(" ORDER BY {0}", string.Join(",", OrderByExpression.ToArray()));
            }
            if (Limit != 0)
            {
                sb.AppendFormat(" LIMIT {0}", Limit.ToString());
            }
            return sb.ToString();
        }

        private void TranslateSelect()
        {
            //if SelectAll, get all property names
            if (SelectType == SelectTypeEnum.SelectAllAndUseAttachModel ||
                SelectType == SelectTypeEnum.SelectAllAndUseReplaceModel)
            {
                //if ReplaceModel and has selected, return
                if (SelectType == SelectTypeEnum.SelectAllAndUseReplaceModel &&
                   SelectByExpression.Any())
                { return; }

                //if AttachModel or has not selected, add all properties
                foreach (var property in SalesforceObjectHelper.GetAllPropertyNames(ElementType))
                {
                    if (SelectByExpression.Contains(property)) { continue; }
                    SelectByExpression.Add(property);
                }
            }

            if (SelectType == SelectTypeEnum.SelectIdAndUseAttachModel ||
                SelectType == SelectTypeEnum.SelectIdAndUseReplaceModel)
            {
                //if ReplaceModel and has selected, return
                if (SelectType == SelectTypeEnum.SelectIdAndUseReplaceModel &&
                    SelectByExpression.Any())
                { return; }

                //if AttachModel or has not selected, add "id"
                foreach (var property in SalesforceObjectHelper.GetAllPropertyNames(ElementType))
                {
                    if (SelectByExpression.Contains("Id")) { continue; }
                    SelectByExpression.Add("Id");
                }
            }
        }

        protected override Expression VisitMethodCall(MethodCallExpression m)
        {
            #region Method On Querable
            if (m.Method.DeclaringType == typeof(Queryable) && m.Method.Name == "Take")
            {
                Limit = (int)((m.Arguments[1] as ConstantExpression).Value);
                this.Visit(m.Arguments[0]);
            }
            if (m.Method.DeclaringType == typeof(Queryable) &&
                (m.Method.Name == "First" || m.Method.Name == "FirstOrDefault" ||
                 m.Method.Name == "Single" || m.Method.Name == "SingleOrDefault"))
            {
                QueryType = (QueryTypeEnum)Enum.Parse(typeof(QueryTypeEnum), m.Method.Name);
                Limit = 2;
                if (m.Arguments.Count > 1)
                {
                    WhereExpression.Insert(0, (this.Visit(m.Arguments[1]) as ConstantExpression).Value.ToString());
                }
                this.Visit(m.Arguments[0]);
            }

            if (m.Method.DeclaringType == typeof(Queryable) && (m.Method.Name == "Any" || m.Method.Name == "Count"))
            {
                QueryType = (QueryTypeEnum)Enum.Parse(typeof(QueryTypeEnum), m.Method.Name);
                if (m.Arguments.Count > 1)
                {
                    WhereExpression.Insert(0, (this.Visit(m.Arguments[1]) as ConstantExpression).Value.ToString());
                }
                this.Visit(m.Arguments[0]);
            }
            if (m.Method.DeclaringType == typeof(Queryable) && m.Method.Name == "Select")
            {
                this.Visit(m.Arguments[1]);
                this.Visit(m.Arguments[0]);
            }
            if (m.Method.DeclaringType == typeof(Queryable) && m.Method.Name == "Where")
            {
                WhereExpression.Insert(0, (this.Visit(m.Arguments[1]) as ConstantExpression).Value.ToString());
                this.Visit(m.Arguments[0]);
            }
            if (m.Method.DeclaringType == typeof(Queryable) && m.Method.Name == "OrderBy")
            {
                var result = this.Visit(m.Arguments[1]) as ConstantExpression;
                if (result != null)
                {
                    OrderByExpression.Insert(0, result.Value.ToString());
                }
                this.Visit(m.Arguments[0]);
            }
            if (m.Method.DeclaringType == typeof(Queryable) && m.Method.Name == "OrderByDescending")
            {
                var result = this.Visit(m.Arguments[1]) as ConstantExpression;
                if (result != null)
                {
                    OrderByExpression.Insert(0, result.Value.ToString() + " DESC");
                }
                this.Visit(m.Arguments[0]);
            }
            #endregion

            #region Method On TSource
            if (m.Method.DeclaringType == typeof(string) && m.Method.Name == "Contains")
            {
                var result = string.Format("{0} LIKE '%{1}%'",
                          (this.Visit(m.Object) as ConstantExpression).Value.ToString(),
                          (this.Visit(m.Arguments[0]) as ConstantExpression).Value.ToString().Trim('\''));
                WhereExpression.Add(result);
            }
            if (m.Method.DeclaringType == typeof(string) && m.Method.Name == "StartsWith")
            {
                var result = string.Format("{0} LIKE '{1}%'",
                          (this.Visit(m.Object) as ConstantExpression).Value.ToString(),
                          (this.Visit(m.Arguments[0]) as ConstantExpression).Value.ToString().Trim('\''));
                WhereExpression.Add(result);
            }
            if (m.Method.DeclaringType == typeof(string) && m.Method.Name == "EndsWith")
            {
                var result = string.Format("{0} LIKE '%{1}'",
                          (this.Visit(m.Object) as ConstantExpression).Value.ToString(),
                          (this.Visit(m.Arguments[0]) as ConstantExpression).Value.ToString().Trim('\''));
                WhereExpression.Add(result);
            }
            #endregion

            return m;
        }

        protected override Expression VisitUnary(UnaryExpression u)
        {
            switch (u.NodeType)
            {
                case ExpressionType.Quote:
                    return this.Visit(u.Operand);
                case ExpressionType.Not:
                    return Expression.Constant((this.Visit(u.Operand) as ConstantExpression).Value + " = false");
                default:
                    throw new NotSupportedException(string.Format("The unary operator '{0}' is not supported", u.NodeType));
            }
        }

        protected override Expression VisitBinary(BinaryExpression b)
        {
            var sb = new StringBuilder();
            sb.Append("(");

            sb.Append((this.Visit(b.Left) as ConstantExpression).Value);

            switch (b.NodeType)
            {
                case ExpressionType.Add:
                    sb.Append(" + ");
                    break;
                case ExpressionType.Subtract:
                    sb.Append(" - ");
                    break;
                case ExpressionType.AndAlso:
                    sb.Append(" AND ");
                    break;
                case ExpressionType.OrElse:
                    sb.Append(" OR ");
                    break;
                case ExpressionType.Equal:
                    sb.Append(" = ");
                    break;
                case ExpressionType.NotEqual:
                    sb.Append(" <> ");
                    break;
                case ExpressionType.LessThan:
                    sb.Append(" < ");
                    break;
                case ExpressionType.LessThanOrEqual:
                    sb.Append(" <= ");
                    break;
                case ExpressionType.GreaterThan:
                    sb.Append(" > ");
                    break;
                case ExpressionType.GreaterThanOrEqual:
                    sb.Append(" >= ");
                    break;
                default:
                    throw new NotSupportedException(string.Format("The binary operator '{0}' is not supported", b.NodeType));
            }

            sb.Append((this.Visit(b.Right) as ConstantExpression).Value);
            sb.Append(")");
            return Expression.Constant(sb.ToString());
        }

        protected override Expression VisitConstant(ConstantExpression c)
        {
            if (c.Value is IQueryable)
            {
                ElementType = (c.Value as IQueryable).ElementType;
                return c;
            }
            if (c.Value == null)
            {
                return Expression.Constant("NULL");
            }
            if (c.Value.GetType() == typeof(SalesforceDate))
            {
                return Expression.Constant(((SalesforceDate)c.Value).ToString());
            }

            switch (Type.GetTypeCode(c.Value.GetType()))
            {
                case TypeCode.String:
                    return Expression.Constant(string.Format("'{0}'", c.Value));
                case TypeCode.DateTime:
                    return Expression.Constant(((DateTime)c.Value).ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.ffffZ"));
                case TypeCode.Object:
                    throw new NotSupportedException(string.Format("The constant for '{0}' is not supported", c.Value));
                default:
                    return Expression.Constant(c.Value.ToString());
            }
        }

        protected override Expression VisitMemberAccess(MemberExpression m)
        {
            var result = m.ToString();
            return Expression.Constant(result.Substring(result.IndexOf('.') + 1));
        }

        protected override Expression VisitLambda(LambdaExpression lambda)
        {
            return this.Visit(lambda.Body);
        }

        protected override Expression VisitMemberInit(MemberInitExpression init)
        {
            foreach (MemberAssignment binding in init.Bindings)
            {
                if (binding.Expression is MemberExpression)
                {
                    SelectByExpression.Add((this.Visit(binding.Expression) as ConstantExpression).Value.ToString());
                }
                else
                {
                    this.Visit(binding.Expression);
                }
            }
            return init;
        }
    }
}
