namespace Xena.Contracts.Helpers
{
    public class ProjectBookkeepData
    {
        public int? InvoicingDate { get; set; }
        public long? InvoiceReportLayoutId { get; set; }
        public long[] OrderIds { get; set; }
        public long? OrderStatusId { get; set; }
        public bool ShowTasks { get; set; }
        public bool ShowLines { get; set; }
    }
}