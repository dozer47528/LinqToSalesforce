using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqToSalesforce.Entity
{
    public enum QueryTypeEnum
    {
        List = 0,
        First,
        FirstOrDefault,
        Single,
        SingleOrDefault,
        Any,
        Count,
    }
}
