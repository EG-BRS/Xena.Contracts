using System;

namespace Xena.Contracts.Domain
{
    public class SubscriptionLineDto:EntityDto
    {
        public long SubscriptionId { get; set; }
        public decimal Quantity { get; set; }
        public string Description { get; set; }
        public string ArticleNumber { get; set; }
        public long? ArticleId { get; set; }
        public long? UnitId { get; set; }
        public long? BilledToId { get; set; }
        public decimal? Fraction { get; set; }
        public decimal? FixedAmount { get; set; }
        public int? Index { get; set; }
        public decimal PriceNettTotal { get; set; }
        public decimal CostTotal { get; set; }
        public decimal DiscountTotal { get; set; }
        public decimal MarginTotal { get; set; }
        public decimal VatEstTotal { get; set; }
        public bool IsCreatedBySystem { get; set; }
        public string SystemIdentifier { get; set; }
        public string SystemMessage { get; set; }
        public long? DepartmentId { get; set; }
        public long? PurposeId { get; set; }
        public long? BearerId { get; set; }
        public long? ArticleVariantId { get; set; }
        public long? LocationId { get; set; }
        public string DepartmentDescription { get; set; }
        public string PurposeDescription { get; set; }
        public string BearerDescription { get; set; }
        public string ArticleVariantAbbreviation { get; set; }
        public string LocationAbbreviation { get; set; }
        public bool ArticleHasInventoryManagement { get; set; }
        public bool ArticleHasVariants { get; set; }
        public long? ArticleGroupId { get; set; }
        public decimal PriceEach { get; set; }
        public decimal MarginTotalRatio { get; set; }
        public decimal MarginTotalPct { get; set; }
        public string ArticleAbbreviation { get; set; }
    }
}