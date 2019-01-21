namespace Xena.Contracts.Helpers
{
    public class ProjectInProgressReportData
    {
        public bool? IsClosed { get; set; }
        public bool LimitToProjectGroup { get; set; }
        public long? ProjectGroupId { get; set; }
        public bool LimitToResponsible { get; set; }
        public long? ResponsibleId { get; set; }
        public long? ReportLayoutId { get; set; }
        public int? DateFrom { get; set; }
        public int? DateTo { get; set; }
        public int? ProjectId { get; set; }
        public int? PartnerId { get; set; }
        public long? ProjectStatusId { get; set; }
        public int? PostingDateFrom { get; set; }
        public int? PostingDateTo { get; set; }
    }
}