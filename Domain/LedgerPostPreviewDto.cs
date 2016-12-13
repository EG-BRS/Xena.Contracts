using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class LedgerPostPreviewDto : EntityDto
    {
        public int Index { get; set; }
        public long VoucherPreviewId { get; set; }

        public decimal? Amount { get; set; }
        public long? LedgerTagId { get; set; }
        public int? LedgerTagNumber { get; set; }
        public string LedgerTagDescription { get; set; }
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
        public string LedgerPostPreviewType { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public string LineDescription
        {
            get
            {
                var description = LedgerTagId.HasValue ? LedgerTagDescription : ArticleGroupId.HasValue ? ArticleGroupDescription : string.Empty;
                return AccountNumber.HasValue ? string.Format("{0} {1}", AccountNumber, description) : description;
            }
        }
        public int? AccountNumber { get; set; }
        public string ShortDescription => AccountNumber.HasValue ? $"{AccountNumber.Value}" : ArticleGroupDescription;
        public string LinkDescription => LedgerTagId.HasValue ? LedgerTagDescription : ArticleGroupId.HasValue ? $"{ArticleGroupDescription}, {LedgerAccount?.GetLocalizedConstant()}" : string.Empty;

        public string ShortLedgerTagDescription
        {
            get { return LedgerTagNumber.HasValue ? LedgerTagNumber.Value.ToString() : LedgerTagDescription; }
        }

        public string LedgerAccount { get; set; }
    }
}