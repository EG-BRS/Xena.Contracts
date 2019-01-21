using System;
using System.Collections;
using System.Collections.Generic;

namespace Xena.Contracts.Helpers
{
    public class CreatePurchaseOrderFromSalesOrderData
    {
        public IList<CreatePurchaseOrderFromSalesOrderLineData> Lines { get; set; }
    }
}