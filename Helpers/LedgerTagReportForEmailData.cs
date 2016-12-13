namespace Xena.Contracts.Helpers
{
    public class LedgerTagReportForEmailData
    {
        public long FiscalPeriodId { get; set; }
        public int? FiscalDateFrom { get; set; }
        public int? FiscalDateTo { get; set; }
        public long? ReportLayoutId { get; set; }
        public long? BearerId { get; set; }
        public long? DepartmentId { get; set; }
        public long? PurposeId { get; set; }
        public string To { get; set; }
        public string CarbonCopy { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IncludeSignature { get; set; }
    }
}