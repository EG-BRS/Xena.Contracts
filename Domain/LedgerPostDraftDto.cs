namespace Xena.Contracts.Domain
{
    public class LedgerPostDraftDto
    {
        public int Index { get; set; }
        public long VoucherDraftId { get; set; }
        public decimal Amount { get; set; }
        public long? LedgerTagId { get; set; }
        public int? LedgerTagNumber { get; set; }
        public string LedgerTagDescription { get; set; }
        public long? ContraTagId { get; set; }
        public int? ContraTagNumber { get; set; }
        public string ContraTagDescription { get; set; }
        public long? VatId { get; set; }
        public string VatAbbreviation { get; set; }
        public string VatDescription { get; set; }
        public long? ArticleGroupId { get; set; }
        public string ArticleGroupDescription { get; set; }
        public string Description { get; set; }
        public long? DepartmentId { get; set; }
        public long? PurposeId { get; set; }
        public long? BearerId { get; set; }
        public string PurposeDescription { get; set; }
        public string DepartmentDescription { get; set; }
        public string BearerDescription { get; set; }
        public decimal? VatDeductionPercentage { get; set; }
    }
}