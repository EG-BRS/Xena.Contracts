using System;

namespace Xena.Contracts.Domain
{
    public class ExternalArticleProviderDto : EntityDto
    {
        public int? Index { get; set; }
        public long SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string Provider { get; set; }
        public long? PartnerId { get; set; }
        public DateTime? LastUpdated { get; set; }
        public int? PartnerAccountNumber { get; set; }
        public long? DefaultArticleGroupId { get; set; }
        public string DefaultArticleGroupDescription { get; set; }
        public decimal DefaultMarkup { get; set; }
        public decimal DefaultDiscount { get; set; }
    }
}