namespace Xena.Contracts.Helpers
{
    public class PartnerSaldoReportData
    {
        public int CalculatedBy { get; set; }
        public int? AccountNumberFrom { get; set; }
        public int? AccountNumberTo { get; set; }
        public decimal? SaldoFrom { get; set; }
        public decimal? SaldoTo{ get; set; }
        public long? ReportLayoutId { get; set; }
        public string ContextType { get; set; }
    }
}