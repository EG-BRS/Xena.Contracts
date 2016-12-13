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
        public bool ArticleIsBundle { get; set; }
        public string ArticleVariantAbbreviation { get; set; }
        public decimal? ArticleWeight { get; set; }
        public string LocationAbbreviation { get; set; }
        public string ArticleStatus { get; set; }
        public long? CurrentPriceAgreementId { get; set; }
        public long? CurrentCostPriceAgreementId { get; set; }
        public long? CurrentPriceDiscountAgreementId { get; set; }
        public long? OrderDeliveryTransactionId { get; set; }
        public string CurrentPriceAgreementDescription { get; set; }
        public string CurrentCostPriceAgreementDescription { get; set; }
        public string CurrentPriceDiscountAgreementDescription { get; set; }
        public long? ArticleMappingId { get; set; }
        public decimal? ArticleMappingQuantity { get; set; }
        public string PartnerArticleNumber { get; set; }
        public bool IsConfirmed { get; set; }

        public string ArticleAbbreviation
        {
            get { return string.IsNullOrEmpty(ArticleVariantAbbreviation) ? ArticleNumber : string.Format("{0}-{1}", ArticleNumber, ArticleVariantAbbreviation); }
        }

        public bool IsDelivered { get; set; }
        public bool ArticleIsDeactivated { get; set; }
    }
}