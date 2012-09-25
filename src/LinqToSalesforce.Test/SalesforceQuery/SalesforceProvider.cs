using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToSalesforce;
using System.Linq.Expressions;
using LinqToSalesforce.Entity;
using System.Configuration;
using LinqToSalesforce.Test.force.com;

/* This class was copied from LinqToSalesforce.Toolkit */

namespace LinqToSalesforce.Toolkit
{
    public class SalesforceProvider<T> : SalesforceProviderBase<T> where T : sObject
    {
        protected override int GetCount(string cmd)
        {
            using (var service = new SalesforceService())
            {
                var results = service.query(cmd);
                return results.size;
            }
        }
        protected override IEnumerable<T> GetEnumerable(string cmd)
        {
            using (var service = new SalesforceService())
            {
                var results = service.query(cmd);
                if (results.records == null) { yield break; }

                foreach (var record in results.records)
                {
                    yield return record as T;
                }
                while (true)
                {
                    if (string.IsNullOrEmpty(results.queryLocator)) { break; }
                    results = service.queryMore(results.queryLocator);
                    foreach (var record in results.records)
                    {
                        yield return record as T;
                    }
                }
            }
        }
    }
}
