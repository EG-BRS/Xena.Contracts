namespace Xena.Contracts.Helpers
{
    public class OngoingOrdersData
    {
        public long? PartnerId { get; set; }
        public long? DepartmentId { get; set; }
        public bool? IsFullyInvoiced { get; set; }
        public int? DateFrom { get; set; }
        public int? DateTo { get; set; }
        public long? ResponsibleId { get; set; }
        public long? CostTypeId { get; set; }
        public long? OrderStatusId { get; set; }
        public long? ReportLayoutId { get; set; }
        public int? InvoicedPer { get; set; }
    }
}
