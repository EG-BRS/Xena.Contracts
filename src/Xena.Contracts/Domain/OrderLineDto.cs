using System.ComponentModel;

namespace Xena.Contracts.Domain
{
    public class OrderLineDto : EntityDto
    {
        private TotalsDto _totals;
        public long? LocationId { get; set; }
        public long? OrderInvoiceTaskId { get; set; }
        public long OrderTaskId { get; set; }
        public long? OrderId { get; set; }
        public long? ProjectId { get; set; }
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
        public TotalsDto Totals
        {
            get { return _totals ?? (_totals = new TotalsDto()); }
            set { _totals = value; }
        }
        public long? ArticleGroupId { get; set; }
        public long? ArticleVariantId { get; set; }
        [ReadOnly(true)]
        public string ArticleGroupDescription { get; set; }
        [ReadOnly(true)]
        public bool ArticleHasInventoryManagement { get; set; }
        [ReadOnly(true)]
        public bool ArticleHasVariants { get; set; }
        [ReadOnly(true)]
        public string ArticleInternalNote { get; set; }
        [ReadOnly(true)]
        public bool ArticleIsBundle { get; set; }
        [ReadOnly(true)]
        public string ArticleVariantAbbreviation { get; set; }
        public decimal? ArticleWeight { get; set; }
        [ReadOnly(true)]
        public string LocationAbbreviation { get; set; }
        public string ArticleStatus { get; set; }
        [ReadOnly(true)]
        public long? OrderDeliveryTransactionId { get; set; }
        public long? ArticleMappingId { get; set; }
        [ReadOnly(true)]
        public decimal? ArticleMappingQuantity { get; set; }
        [ReadOnly(true)]
        public string PartnerArticleNumber { get; set; }
        public bool IsConfirmed { get; set; }
        private string _articleAbbreviation = null;
        [ReadOnly(true)]
        public string ArticleAbbreviation
        {
            get
            {
                return _articleAbbreviation ?? (string.IsNullOrEmpty(ArticleVariantAbbreviation)
                           ? ArticleNumber
                           : $"{ArticleNumber}-{ArticleVariantAbbreviation}");
            }
            set { _articleAbbreviation = value; }
        }
        public bool IsDelivered { get; set; }
        public bool ArticleIsDeactivated { get; set; }
        [ReadOnly(true)]
        public decimal? AverageCostPrice { get; set; }
        private decimal? _estimatedCostTotal = null;
        [ReadOnly(true)]
        public decimal EstimatedCostTotal
        {
            get
            {
                return _estimatedCostTotal ??
                       (AverageCostPrice.HasValue ? AverageCostPrice.Value * Quantity : Totals.CostTotal);
            }
            set { _estimatedCostTotal = value; }
        }

        public string OrderLineStatusColor { get; set; }
        public string OrderLineStatusName { get; set; }
        [ReadOnly(true)]
        public bool HasLinkedLines { get; set; }
    }
}

