namespace Xena.Contracts.Helpers
{
    public class ArticlePostReportData
    {
        public int DateFrom { get; set; }
        public int DateTo { get; set; }
        public long? ArticleId { get; set; }
        public long? LocationId { get; set; }
        public long? WarehouseId { get; set; }
        public long? ReportLayoutId { get; set; }
    }
}