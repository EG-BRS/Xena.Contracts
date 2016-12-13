namespace Xena.Contracts.Helpers
{
    public class HistoricStockValueReportData
    {
        public long? ArticleGroupId { get; set; }
        public int FiscalDate { get; set; }
        public long? LocationId { get; set; }
        public long? WarehouseId { get; set; }
        public long? ReportLayoutId { get; set; }
    }
}