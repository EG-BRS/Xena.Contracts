namespace Xena.Contracts.Helpers
{
    public class OngoingOrdersHistoricData
    {
        public long? PartnerId { get; set; }
        public long? DepartmentId { get; set; }
        public long? ResponsibleId { get; set; }
        public long? CostTypeId { get; set; }
        public long? OrderStatusId { get; set; }
        public long? ReportLayoutId { get; set; }
        public int? OpenPer { get; set; }
    }
}