namespace Xena.Contracts.Helpers
{
    public class InvoiceListReportData
    {
        public string QueryString { get; set; }
        public string ContextType { get; set; }
        public string DeliverFilter { get; set; }
        public bool? IsSettled { get; set; }
        public long? ReportLayoutId { get; set; }
    }
}