namespace Xena.Contracts.Helpers
{
    public class PartnerPostReportData
    {
        public int DateFrom { get; set; }
        public int DateTo { get; set; }
        public long? PartnerId { get; set; }
        public long? ReportLayoutId { get; set; }
        public string ContextType { get; set; }
        public bool? IncludeSettled { get; set; }
    }
}