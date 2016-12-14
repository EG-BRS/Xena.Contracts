using Xena.Contracts.Domain;


namespace Xena.Contracts.Helpers
{
    public class CalculatedArticleAvailabilityDto : IHasIdDto
    {
        public long? Id { get; set; }
        public long ArticleId { get; set; }
        public string ArticleNumber { get; set; }
        public string ArticleDescription { get; set; }
        public long? ArticleVariantId { get; set; }
        public string ArticleVariantAbbreviation { get; set; }
        public bool ArticleHasInventoryManagement { get; set; }
        public bool ArticleHasVariants { get; set; }
        public long FiscalSetupId { get; set; }
        public decimal AvailableQuantity { get; set; }
        public decimal? AverageCostPrice { get; set; }
        public decimal ReservedQuantity { get; set; }
        public decimal OpenSalesOrderQuantity { get; set; }
        public decimal OpenPurchaseOrderQuantity { get; set; }
        public decimal ConfirmedPurchaseQuantity { get; set; }
        public decimal ConfirmedSalesQuantity { get; set; }
        public long? LocationId { get; set; }
        public long? WarehouseId { get; set; }
        public string WarehouseDescription { get; set; }
        public string LocationAbbreviation { get; set; }

        public decimal DisposableQuantity { get; set; }

        public string LocationFriendlyText { get; set; }
        public string Abbreviation { get; set; }
        public string Description { get; set; }

    }
}