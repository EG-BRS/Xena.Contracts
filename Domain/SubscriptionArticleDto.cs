namespace Xena.Contracts.Domain
{
    public class SubscriptionArticleDto : IHasIdDto
    {
        public long ArticleId { get; set; }
        public decimal Quantity { get; set; }
        public long FiscalSetupId { get; set; }
        public string Description { get; set; }
        public int NextRunDateDays { get; set; }
        public bool IsDeactivated { get; set; }
        public bool IsActive { get; set; }
        public long? CustomerId { get; set; }
        public string PartnerName { get; set; }
        public int? PartnerAccountNumber { get; set; }
        public long? Id { get; set; }
    }
}