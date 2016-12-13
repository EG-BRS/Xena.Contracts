
namespace Xena.Contracts.Domain
{
    public class OrderLineBundleItemDto : EntityDto
    {
        public long OrderLineId { get; set; }
        public long? ArticleId { get; set; }
        public string ArticleNumber { get; set; }
        public bool ArticleHasVariants { get; set; }
        public decimal Multiplier { get; set; }
        public long? ArticleVariantId { get; set; }
        public string ArticleDescription { get; set; }
        public bool ArticleHasInventoryManagement { get; set; }
        public string ArticleVariantAbbreviation { get; set; }
        public long? LocationId { get; set; }
        public string LocationAbbreviation { get; set; }
        public string ArticleAbbreviation
        {
            get { return string.IsNullOrEmpty(ArticleVariantAbbreviation) ? ArticleNumber : string.Format("{0}-{1}", ArticleNumber, ArticleVariantAbbreviation); }
        }

        public bool IsConfirmed { get; set; }
        public bool IsDelivered { get; set; }
        public string ContextType { get; set; }
        public decimal CalculatedQuantity { get; set; }
        public string ArticleStatus { get; set; }
    }
}