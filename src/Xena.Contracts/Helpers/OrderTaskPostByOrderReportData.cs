namespace Xena.Contracts.Helpers
{
    public class OrderTaskPostByOrderReportData
    {
        public int DateFrom { get; set; }
        public int DateTo { get; set; }
        public long? ProjectId { get; set; }
        public long? ResponsibleId { get; set; }
        public long? ResourceId { get; set; }
        public long? CostTypeId { get; set; }
        public long? OrderId { get; set; }
        public long? OrderTaskId { get; set; }
        public long? OrderTaskStatusId { get; set; }
        public bool LimitToProject { get; set; }
        public bool LimitToResponsible { get; set; }
        public bool LimitToResource { get; set; }
        public bool LimitToCostType { get; set; }
        public long? ReportLayoutId { get; set; }
    }
}