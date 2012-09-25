using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqToSalesforce.Toolkit.Mock
{
    public class SforceService : IDisposable
    {
        public string Url { get; set; }
        public SessionHeader SessionHeaderValue { get; set; }

        public LoginResult login(string username, string password)
        {
            return new LoginResult();
        }

        public SaveResult[] update(sObject[] items)
        {
            return new SaveResult[0];
        }

        public SaveResult[] create(sObject[] items)
        {
            return new SaveResult[0];
        }

        public DeleteResult[] delete(string[] items)
        {
            return new DeleteResult[0];
        }

        public QueryResult query(string soql)
        {
            return new QueryResult();
        }

        public QueryResult queryMore(string soql)
        {
            return new QueryResult();
        }

        public void Dispose()
        {
        }
    }

    public class SessionHeader
    {
        public string sessionId { get; set; }
    }

    public class LoginResult
    {
        public string serverUrl { get; set; }
        public string sessionId { get; set; }
    }

    public class sObject { }

    public class SaveResult { }

    public class QueryResult
    {
        public string queryLocator { get; set; }
        public int size { get; set; }
        public sObject[] records { get; set; }
    }

    public class DeleteResult { }

}
