namespace Xena.Contracts.Helpers
{
    public class ArticleAvailabilityData
    {
        public long ArticleId { get; set; }
        public string ArticleNumber { get; set; }
        public string ArticleDescription { get; set; }
        public decimal NewAvailableQuantity { get; set; }
        public decimal AvailableQuantity { get; set; }
        public bool ArticleHasVariants { get; set; }
        public long? LocationId { get; set; }
        public string ArticleVariantAbbreviation { get; set; }
        public decimal AverageCostPrice { get; set; }
        public long? NewLocationId { get; set; }
        public long? WarehouseId { get; set; }
        public string WarehouseDescription { get; set; }
        public string LocationAbbreviation { get; set; }
        public long Id { get; set; }
        public decimal ReservedQuantity { get; set; }
        public decimal OpenSalesOrderQuantity { get; set; }
        public decimal OpenPurchaseOrderQuantity { get; set; }
        public long FiscalSetupId { get; set; }
        public long? ArticleVariantId { get; set; }
        public long? NewArticleVariantId { get; set; }
    }
}