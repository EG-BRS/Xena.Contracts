namespace Xena.Contracts.Helpers
{
    public class PartnerSaldoAgeReportData
    {
        public int CalculatedBy { get; set; }
        public int? AccountNumberFrom { get; set; }
        public int? AccountNumberTo { get; set; }
        public long? ReportLayoutId { get; set; }
        public string ContextType { get; set; } 
    }
}