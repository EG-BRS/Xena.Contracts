namespace Xena.Contracts.Helpers
{
    public class ArticleMappingImportData
    {
        public string ArticleNumber { get; set; }
        public string PartnerArticleNumber { get; set; }
        public string PartnerArticleDescription { get; set; }
        public decimal? Quantity { get; set; }
        public override string ToString()
        {
            return string.Format("{0} <-> {1}", ArticleNumber, PartnerArticleNumber);
        }
    }
}