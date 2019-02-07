namespace Xena.Contracts.Helpers
{
    public class ResourcePostReportData
    {
        public int DateFrom { get; set; }
        public int DateTo { get; set; }
        public long[] ResourceIds { get; set; }
        public bool? IsPaid { get; set; }
        public bool? IsAtWork { get; set; }
        public bool? IsBillable { get; set; }
        public long? ReportLayoutId { get; set; }
        public long? OrderId { get; set; }
        public long[] OrderTaskIds { get; set; }
    }
}