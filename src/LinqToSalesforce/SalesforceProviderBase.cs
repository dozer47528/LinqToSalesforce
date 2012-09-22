using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using LinqToSalesforce.Helper;
using LinqToSalesforce.Entity;

namespace LinqToSalesforce
{
    public abstract class SalesforceProviderBase<T> : QueryProvider
    {
        public override object Execute(Expression expression)
        {
            var visitor = new SalesforceVisitor();
            var cmd = visitor.Translate(PartialEvaluator.Eval(expression));
            switch (visitor.QueryType)
            {
                case QueryTypeEnum.FirstOrDefault:
                    return GetEnumerable(cmd).FirstOrDefault();
                case QueryTypeEnum.First:
                    return GetEnumerable(cmd).First();
                case QueryTypeEnum.Single:
                    return GetEnumerable(cmd).Single();
                case QueryTypeEnum.SingleOrDefault:
                    return GetEnumerable(cmd).SingleOrDefault();
                case QueryTypeEnum.Count:
                    return GetCount(cmd);
                case QueryTypeEnum.Any:
                    return GetCount(cmd) > 0;
                default:
                    return GetEnumerable(cmd);
            }
        }

        protected abstract int GetCount(string cmd);
        protected abstract IEnumerable<T> GetEnumerable(string cmd);

        public string ToString(Expression expression)
        {
            var visitor = new SalesforceVisitor();
            return visitor.Translate(PartialEvaluator.Eval(expression));
        }
    }
}
