namespace Xena.Contracts.Domain
{
    public class PurchaseDraftLineDto : EntityDto
    {
        public long PurchaseDraftId { get; set; }
        public long ArticleId { get; set; }
        public long? ArticleVariantId { get; set; }
        public decimal Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public string ArticleNumber { get; set; }
        public string ArticleDescription { get; set; }
        public string ArticleVariantAbbreviation { get; set; }
    }
}