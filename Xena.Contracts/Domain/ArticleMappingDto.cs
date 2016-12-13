namespace Xena.Contracts.Domain
{
    public class ArticleMappingDto : EntityDto
    {
        public long? ArticleId { get; set; }
        public string ArticleNumber { get; set; }
        public string ArticleDescription { get; set; }
        public long? ArticleVariantId { get; set; }
        public bool? ArticleHasVariants { get; set; }
        public string ArticleVariantAbbreviation { get; set; }
        public long? PartnerId { get; set; }
        public string PartnerName { get; set; }
        public int? PartnerAccountNumber { get; set; }
        public string PartnerArticleNumber { get; set; }
        public decimal Quantity { get; set; }
        public long? UnitId { get; set; }
        public string UnitAbbreviation { get; set; }

        public string ArticleAbbreviation

        {
            get { return string.IsNullOrEmpty(ArticleVariantAbbreviation) ? ArticleNumber : string.Format("{0}-{1}", ArticleNumber, ArticleVariantAbbreviation); }
        }  
        
        public string PartnerArticleDescription { get; set; }
    }
}