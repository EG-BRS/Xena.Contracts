namespace Xena.Contracts.Helpers
{
    public class LedgerPostReportData
    {
        public int DateFrom { get; set; }
        public int DateTo { get; set; }
        public string LedgerAccount { get; set; }
        public long? ArticleGroupId { get; set; }
        public long? LedgerTagId { get; set; }
        public long? VatId { get; set; }
        public long? DepartmentId { get; set; }
        public long? BearerId { get; set; }
        public long? PurposeId { get; set; }
        public long? PartnerId { get; set; }
        public bool LimitToArticleGroup { get; set; }
        public bool LimitToLedgerTag { get; set; }
        public bool LimitToVat { get; set; }
        public bool LimitToDepartment { get; set; }
        public bool LimitToBearer { get; set; }
        public bool LimitToPurpose { get; set; }
        public bool LimitToPartner { get; set; }
        public long? ReportLayoutId { get; set; }
    }
}