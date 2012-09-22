using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqToSalesforce.Entity
{
    public enum SelectTypeEnum
    {
        /// <summary>
        /// For Default
        /// </summary>
        SelectIdAndUseAttachModel,
        SelectIdAndUseReplaceModel,
        SelectAllAndUseReplaceModel,
        SelectAllAndUseAttachModel,
    }
}
