

namespace Xena.Contracts.Domain
{
    public class LedgerTagStatementContextDto: IHasIdDto
    {
        public long ReportSubscriptionId { get; set; }
        public long? ReportLayoutId { get; set; }
        public long? DepartmentId { get; set; }
        public long? BearerId { get; set; }
        public long? PurposeId { get; set; }
        public long? ArticleGroupId { get; set; }
        public long? LedgerTagId { get; set; }
        public long? VatId { get; set; }
        public string LedgerAccount { get; set; }
        public long? Id { get; set; }
        public string ReportLayoutName { get; set; }
        public string BearerDescription { get; set; }
        public string DepartmentDescription { get; set; }   
        public string PurposeDescription { get; set; }
        public string ArticleGroupDescription { get; set; }
        public string VatAbbreviation { get; set; }
        public string VatDescription { get; set; }
        public int? LedgerTagNumber { get; set; }
        public string LedgerTagDescription { get; set; }

        public string LedgerAccountTranslated
        { get; set; }
    }
}