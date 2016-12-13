namespace Xena.Contracts.Helpers
{
    public class ArticleGroupReportForEmailData
    {
        public string LedgerAccount { get; set; }
        public long FiscalPeriodId { get; set; }
        public int? FiscalDateFrom { get; set; }
        public int? FiscalDateTo { get; set; }
        public long? ReportLayoutId { get; set; }
        public string To { get; set; }
        public string CarbonCopy { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IncludeSignature { get; set; }
    }
}