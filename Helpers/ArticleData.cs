namespace Xena.Contracts.Helpers
{
    public class ArticleData
    {
        public long? ArticleId { get; set; }
        public string ArticleDescription { get; set; }
        public decimal QuantityMonth { get; set; }
        public decimal QuantityYearToDate { get; set; }
    }
}