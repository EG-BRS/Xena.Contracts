namespace Xena.Contracts.Helpers
{
    public class ArticleStockStatisticsReportData
    {
        public long? ArticleId { get; set; }
        public long? ArticleGroupId { get; set; }
        public long? LocationId { get; set; }
        public long? WarehouseId { get; set; }
        public long? ReportLayoutId { get; set; }
        public int DateFrom { get; set; }
        public int DateTo { get; set; }
    }
}