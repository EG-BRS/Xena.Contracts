namespace Xena.Contracts.Domain
{
    public class OrderLineDto : EntityDto
    {
        public long? LocationId { get; set; }
        public long? OrderInvoiceTaskId { get; set; }
        public long OrderTaskId { get; set; }
        public int? Index { get; set; }
        public long? ArticleId { get; set; }
        public int? InvoiceDateDays { get; set; }
        public decimal CostEach { get; set; }
        public string Description { get; set; }
        public decimal PriceEach { get; set; }
        public decimal Quantity { get; set; }
        public long? UnitId { get; set; }
        public long? PayerId { get; set; }
        public int? PayerAccountNumber { get; set; }
        public string UnitAbbreviation { get; set; }
        public string ArticleNumber { get; set; }
        public TotalsDto Totals { get; set; }
        public long? ArticleGroupId { get; set; }
        public long? ArticleVariantId { get; set; }
        public string ArticleGroupDescription { get; set; }
        public bool ArticleHasInventoryManagement { get; set; }
        public bool ArticleHasVariants { get; set; }
        public string ArticleInternalNote { get; set; }
        public bool ArticleIsBundle { get; set; }
        public string ArticleVariantAbbreviation { get; set; }
        public decimal? ArticleWeight { get; set; }
        public string LocationAbbreviation { get; set; }
        public string ArticleStatus { get; set; }
        public long? OrderDeliveryTransactionId { get; set; }
        public long? ArticleMappingId { get; set; }
        public decimal? ArticleMappingQuantity { get; set; }
        public string PartnerArticleNumber { get; set; }
        public bool IsConfirmed { get; set; }

        public string ArticleAbbreviation { get; set; }

        public bool IsDelivered { get; set; }
        public bool ArticleIsDeactivated { get; set; }
        public decimal? AverageCostPrice { get; set; }
        public decimal EstimatedCostTotal { get; set; }

        public string OrderLineStatusColor { get; set; }
        public string OrderLineStatusName { get; set; }
        public bool HasLinkedLines { get; set; }
    }
}
