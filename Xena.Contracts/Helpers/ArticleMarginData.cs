namespace Xena.Contracts.Helpers
{
    public class ArticleMarginData
    {
        public long? Id { get; set; }
        public long ArticleId { get; set; }
        public string ArticleNumber { get; set; }
        public string ArticleDescription { get; set; }
        public long ArticleGroupId { get; set; }
        public string ArticleGroupDescription { get; set; }
        public decimal Turnover { get; set; }
        public decimal Consumption { get; set; }
        public decimal Margin => Turnover - Consumption;
        public decimal? MarginRatio => Turnover == decimal.Zero ? (decimal?) null : Margin/Turnover*100M;
    }
}