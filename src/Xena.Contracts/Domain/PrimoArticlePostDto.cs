namespace Xena.Contracts.Domain
{
    public class PrimoArticlePostDto : EntityDto
    {
        public long FiscalPeriodId { get; set; }
        public decimal AveragePrice { get; set; }
        public decimal Quantity { get; set; }
        public long? ArticleId { get; set; }
        public long? ArticleVariantId { get; set; }
        public long? LocationId { get; set; }
        public string LocationAbbreviation { get; set; }
        public string ArticleDescription { get; set; }
        public string ArticleVariantAbbreviation { get; set; }
        public string ArticleVariantDescription { get; set; }
        public string ArticleNumber { get; set; }
        public string ArticleAbbreviation
        { get; set; }

        public string Description
        { get; set; }
    }
}