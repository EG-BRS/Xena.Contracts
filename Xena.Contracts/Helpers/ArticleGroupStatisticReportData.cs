namespace Xena.Contracts.Helpers
{
    public class ArticleGroupStatisticReportData
    {
        public long ArticleGroupId { get; set; }
        public long? FiscalPeriodId { get; set; }
        public long? DepartmentId { get; set; }
        public long? BearerId { get; set; }
        public long? PurposeId { get; set; }
        public bool LimitToDepartment { get; set; }
        public bool LimitToBearer { get; set; }
        public bool LimitToPurpose { get; set; }
        public long? ReportLayoutId { get; set; }
        public int? EndDate { get; set; }
    }
}