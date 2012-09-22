using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using LinqToSalesforce.Helper;

namespace LinqToSalesforce
{
    public class SalesforceQuery<T> : Query<T>
    {
        public SalesforceQuery(IQueryProvider provider) : base(provider) { }
        public SalesforceQuery(IQueryProvider provider, Type staticType) : base(provider, staticType) { }
        public SalesforceQuery(QueryProvider provider, Expression expression) : base(provider, expression) { }
    }
}
