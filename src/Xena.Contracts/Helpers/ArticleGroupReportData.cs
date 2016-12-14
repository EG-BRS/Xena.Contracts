namespace Xena.Contracts.Helpers
{
    public class ArticleGroupReportData
    {
        public string LedgerAccount { get; set; }
        public long FiscalPeriodId { get; set; }
        public int? FiscalDateFrom { get; set; }
        public int? FiscalDateTo { get; set; }
        public long? ReportLayoutId { get; set; }
    }
}