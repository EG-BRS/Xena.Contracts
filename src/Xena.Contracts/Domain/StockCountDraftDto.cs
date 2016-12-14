namespace Xena.Contracts.Domain
{
    public class StockCountDraftDto : EntityDto
    {
        public long StockCountId { get; set; }
        public string StockCountDescription { get; set; }
        public long? LocationId { get; set; }
        public string LocationAbbreviation { get; set; }
        public long? ArticleId { get; set; }
        public bool ArticleHasVariants { get; set; }
        public string ArticleNumber { get; set; }
        public string ArticleDescription { get; set; }
        public long? ArticleVariantId { get; set; }
        public string ArticleVariantAbbreviation { get; set; }
        public decimal Quantity { get; set; }
        public decimal QuantityReserved { get; set; }
        public decimal? QuantityCounted { get; set; }
    }
}