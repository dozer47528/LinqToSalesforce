using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace LinqToSalesforce.Helper
{
    public static class SalesforceObjectHelper
    {

        public static List<string> GetAllPropertyNames(Type t)
        {
            var result = new List<string>();
            foreach (var property in t.GetProperties())
            {
                var type = property.PropertyType;
                if (type == typeof(string) ||
                    type == typeof(decimal?) ||
                    type == typeof(DateTime?))
                {
                    result.Add(property.Name);
                }
            }
            return result;
        }
    }
}
