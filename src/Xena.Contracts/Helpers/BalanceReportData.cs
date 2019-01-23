namespace Xena.Contracts.Helpers
{
    public class BalanceReportData
    {
        public int? FiscalDateFrom { get; set; }
        public int? FiscalDateTo { get; set; }
        public long? ReportLayoutId { get; set; }
        public long[] BearerId { get; set; }
        public long[] DepartmentId { get; set; }
        public long[] PurposeId { get; set; }
    }
}