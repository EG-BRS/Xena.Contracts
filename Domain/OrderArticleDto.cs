namespace Xena.Contracts.Domain
{
    public class OrderArticleDto : IHasIdDto
    {
        public long ArticleId { get; set; }
        public int OrderNumber { get; set; }
        public long? PartnerId { get; set; }
        public string PartnerName { get; set; }
        public int? PartnerAccountNumber { get; set; }
        public string ContextType { get; set; }
        public int? DateDays { get; set; }
        public bool IsDeactivated { get; set; }
        public bool IsFullyInvoiced { get; set; }
        public decimal Quantity { get; set; }
        public long FiscalSetupId { get; set; }
        public long? Id { get; set; }
    }
}