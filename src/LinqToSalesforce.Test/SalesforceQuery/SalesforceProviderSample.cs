using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToSalesforce;
using System.Linq.Expressions;
using LinqToSalesforce.Entity;
using LinqToSalesforce.Test.force.com;
using System.Configuration;

namespace LinqToSalesforce.Test.SalesforceQuery
{
    public class SalesforceProviderSample<T> : SalesforceProviderBase<T> where T : sObject
    {
        private static SforceService service = new SforceService();
        public void Login()
        {
            if (service.SessionHeaderValue != null) return;
            var username = ConfigurationManager.AppSettings["username"];
            var password = ConfigurationManager.AppSettings["password"];
            var loginResult = service.login(username, password);
            service.Url = loginResult.serverUrl;
            service.SessionHeaderValue = new SessionHeader();
            service.SessionHeaderValue.sessionId = loginResult.sessionId;
        }

        protected override int GetCount(string cmd)
        {
            Login();
            var results = service.query(cmd);
            return results.size;
        }

        protected override IEnumerable<T> GetEnumerable(string cmd)
        {
            Login();
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
