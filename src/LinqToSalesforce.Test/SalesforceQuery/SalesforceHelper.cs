using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Reflection;
using System.Linq.Expressions;
using LinqToSalesforce;
using LinqToSalesforce.Entity;
using LinqToSalesforce.Toolkit;
using LinqToSalesforce.Test.force.com;

/* This class was copied from LinqToSalesforce.Toolkit */

namespace LinqToSalesforce.Toolkit
{
    public class SalesforceHelper
    {
        #region method for query
        public SaveResult Update(sObject item)
        {
            using (var service = new SalesforceService())
            {
                var results = service.update(new sObject[] { item })[0];
                return results;
            }
        }

        public SaveResult[] Update(IEnumerable<sObject> items)
        {
            using (var service = new SalesforceService())
            {
                var list = new sObjectList<sObject>(items, 200);
                var results = new List<SaveResult>();

                foreach (var smallList in list)
                {
                    results.AddRange(service.update(smallList));
                }

                return results.ToArray();
            }
        }

        public SaveResult Create(sObject item)
        {
            using (var service = new SalesforceService())
            {
                var results = service.create(new sObject[] { item })[0];
                return results;
            }
        }

        public SaveResult[] Create(sObject[] items)
        {
            using (var service = new SalesforceService())
            {
                var list = new sObjectList<sObject>(items);
                var results = new List<SaveResult>();

                foreach (var smallList in list)
                {
                    results.AddRange(service.create(smallList));
                }

                return results.ToArray();
            }
        }

        public DeleteResult Delete(string id)
        {
            using (var service = new SalesforceService())
            {
                var results = service.delete(new string[] { id })[0];
                return results;
            }
        }

        public DeleteResult[] Delete(IEnumerable<string> ids)
        {
            using (var service = new SalesforceService())
            {
                var results = service.delete(ids.ToArray());
                return results;
            }
        }

        public SalesforceQuery<T> Query<T>(SelectTypeEnum selectType = SelectTypeEnum.SelectIdAndUseAttachModel) where T : sObject
        {
            return new SalesforceQuery<T>(new SalesforceProvider<T> { SelectType = selectType });
        }
        #endregion
    }


    #region HelperClass
    /// <summary>
    /// SalesFocrce Query Helper
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public sealed class sObjectList<T> : IEnumerable<T[]> where T : sObject
    {
        private readonly List<T> items = new List<T>();
        public List<T> Items { get { return items; } }

        private int queryLength;
        /// <summary>
        /// the max query length is 200
        /// </summary>
        public int QueryLength
        {
            get { return queryLength; }
            set { queryLength = value > 0 && value <= 200 ? value : 1; }
        }

        public sObjectList() : this(200) { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="length">query length</param>
        public sObjectList(int length)
        {
            QueryLength = length;
        }
        public sObjectList(IEnumerable<sObject> list) : this(list, 200) { }
        public sObjectList(IEnumerable<sObject> list, int length)
        {
            Items.AddRange(list as IEnumerable<T>);
            QueryLength = length;
        }

        public IEnumerator<T[]> GetEnumerator()
        {
            var count = Items.Count;
            for (var k = 0; k < count; k += queryLength)
            {
                if (k + queryLength > count)
                {
                    yield return Items.GetRange(k, count - k).ToArray();
                }
                else
                {
                    yield return Items.GetRange(k, queryLength).ToArray();
                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    /// <summary>
    /// SforceService Helper
    /// </summary>
    public sealed class SalesforceService : SforceService
    {
        public static string SavedSessionID { get; set; }
        public static string SavedServerUrl { get; set; }
        public readonly string username = System.Configuration.ConfigurationManager.AppSettings["sfusername"];
        public readonly string password = System.Configuration.ConfigurationManager.AppSettings["sfpassword"];
        public SalesforceService()
        {
            CheckLogin();
            this.Url = SavedServerUrl;
            this.SessionHeaderValue = new SessionHeader();
            this.SessionHeaderValue.sessionId = SavedSessionID;
        }
        public void CheckLogin()
        {
            if (string.IsNullOrEmpty(SavedSessionID) || string.IsNullOrEmpty(SavedServerUrl))
            {
                var result = this.login(username, password);
                SavedServerUrl = result.serverUrl;
                SavedSessionID = result.sessionId;
            }
        }
    }
    #endregion
}
