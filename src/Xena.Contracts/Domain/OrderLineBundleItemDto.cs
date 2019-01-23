
using System.ComponentModel;

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
        [ReadOnly(true)]
        public string ArticleInternalNote { get; set; }
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
        public bool IsConfirmed { get; set; }
        public bool IsDelivered { get; set; }
        public string ContextType { get; set; }
        public decimal CalculatedQuantity { get; set; }
        public string ArticleStatus { get; set; }
    }
}