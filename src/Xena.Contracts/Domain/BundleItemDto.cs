using System;

namespace Xena.Contracts.Domain
{
    public class BundleItemDto : EntityDto
    {
        public long ArticleBundleContextId { get; set; }
        public long? ArticleId { get; set; }
        public string ArticleNumber { get; set; }
        public long? ArticleVariantId { get; set; }
        public long? ArticleHasVariants { get; set; }
        public string ArticleVariantAbbreviation { get; set; }
        public decimal Multiplier { get; set; }
        public long ParentArticleId { get; set; }
        public string ArticleDescription { get; set; }
        public bool AdvancedPurchasePrices { get; set; }
        public decimal? PurchasePrice { get; set; }
        public string PurchaseCurrencyAbbreviation { get; set; }
        public bool AdvancedSalesPrices { get; set; }
        public decimal? SalesPrice { get; set; }
        public string SalesCurrencyAbbreviation { get; set; }
        public string ArticleAbbreviation { get; set; }
    }
}