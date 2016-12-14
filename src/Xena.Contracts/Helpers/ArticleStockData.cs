

namespace Xena.Contracts.Helpers
{
    public class ArticleStockData
    {
        public long? Id { get; set; }
        public long ArticleId { get; set; }
        public string ArticleNumber { get; set; }
        public string ArticleDescription { get; set; }
        public long? ArticleVariantId { get; set; }
        public string ArticleVariantAbbreviation { get; set; }
        public long FiscalSetupId { get; set; }
        public decimal AvailableQuantity { get; set; }
        public decimal? AverageCostPrice { get; set; }

        public long? LocationId { get; set; }
        public long? WarehouseId { get; set; }
        public string WarehouseDescription { get; set; }
        public string LocationAbbreviation { get; set; }
        public decimal? TotalStockValue { get; set; }
    }
}