using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using LinqToSalesforce.Entity;

namespace LinqToSalesforce.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var provider = new SalesforceProvider<User>();
            IQueryable<User> query = new SalesforceQuery<User>(provider);
            var result = query
                .Select(c => new User
                {
                    Id = c.Id,
                    User__c = new User
                    {
                        Id = c.User__c.Id,
                        Name = c.User__c.Name,
                        User__c = new User
                        {
                            Name = c.User__c.User__c.Name,
                        }
                    }
                })
                .Where(u => u.Name.StartsWith("aaa"))
                .Take(10)
                .First();
        }
    }


    public class SalesforceProvider<User> : SalesforceProviderBase<User>
    {
        protected override int GetCount(string cmd)
        {
            throw new NotImplementedException();
        }

        protected override IEnumerable<User> GetEnumerable(string cmd)
        {
            throw new NotImplementedException();
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public User User__c { get; set; }
    }
}
