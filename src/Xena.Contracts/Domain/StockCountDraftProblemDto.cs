namespace Xena.Contracts.Domain
{
    public class StockCountDraftProblemDto : FiscalDto
    {
        public long Id { get; set; }
        public long StockCountId { get; set; }
        public decimal? Sum { get; set; }
        public int Count { get; set; }
        public decimal Quantity { get; set; }
        public decimal QuantityReserved { get; set; }
        public string ArticleNumber { get; set; }
        public string LocationAbbreviation { get; set; }
        public string ArticleVariantAbbreviation { get; set; }
    }
}