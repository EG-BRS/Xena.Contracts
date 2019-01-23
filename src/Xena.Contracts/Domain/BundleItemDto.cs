using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Xena.Contracts.Domain
{
    public class BundleItemDto : EntityDto
    {
        [Required]
        public long ArticleBundleContextId { get; set; }
        [Required]
        public long ParentArticleId { get; set; }
        public long? ArticleId { get; set; }
        public long? ArticleVariantId { get; set; }
        public decimal Multiplier { get; set; }

        //Convinience properties
        [ReadOnly(true)]
        public bool AdvancedPurchasePrices { get; set; }
        [ReadOnly(true)]
        public decimal? PurchasePrice { get; set; }
        [ReadOnly(true)]
        public string PurchaseCurrencyAbbreviation { get; set; }
        [ReadOnly(true)]
        public bool AdvancedSalesPrices { get; set; }
        [ReadOnly(true)]
        public decimal? SalesPrice { get; set; }
        [ReadOnly(true)]
        public string SalesCurrencyAbbreviation { get; set; }
        [ReadOnly(true)]
        public string ArticleNumber { get; set; }

        private string _articleAbbrevation;
        [ReadOnly(true)]
        public string ArticleAbbreviation
        {
            get
            {
                return _articleAbbrevation ?? (string.IsNullOrEmpty(ArticleVariantAbbreviation)
                           ? ArticleNumber
                           : $"{ArticleNumber}-{ArticleVariantAbbreviation}");
            }
            set { _articleAbbrevation = value; }
        }

        [ReadOnly(true)]
        public string ArticleDescription { get; set; }
        [ReadOnly(true)]
        public long? ArticleHasVariants { get; set; }
        [ReadOnly(true)]
        public string ArticleVariantAbbreviation { get; set; }
    }
}