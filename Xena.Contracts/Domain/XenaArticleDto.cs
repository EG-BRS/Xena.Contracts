namespace Xena.Contracts.Domain
{
    public class XenaArticleDto
    {
        public long Id { get; set; }
        public decimal? SalesPrice { get; set; }
        public decimal VatPercentage { get; set; }
        public string ArticleNumber { get; set; }
        public long FiscalSetupId { get; set; }
    }
}