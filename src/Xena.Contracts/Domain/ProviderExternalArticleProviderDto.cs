using System;

namespace Xena.Contracts.Domain
{
    public class ProviderExternalArticleProviderDto : EntityDto
    {
        public long SupplierId { get; set; }
        public string SupplierName { get; set; }
    }
}