using System;

namespace Xena.Contracts.Domain
{
    public class ClientExternalArticleProviderDto : IHasIdDto
    {
        public long? Id { get; set; }
        public long ProviderId { get; set; }
        public long SupplierId { get; set; }
        public string SupplierName { get; set; }
    }
}