using System;

namespace Xena.Contracts.Helpers
{
    public class ExternalArticleSupplierData
    {
        public long SupplierId { get; set; }
        public string SupplierName { get; set; }
        public DateTime Updated { get; set; }
        public string Provider { get; set; }
    }
}