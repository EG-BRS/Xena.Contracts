using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class LedgerTagDto : EntityDto
    {
        public string LedgerAccount { get; set; }
        public string LedgerTagType { get; set; }
        public string LedgerAccountTranslated { get { return string.IsNullOrEmpty(LedgerAccount)?string.Empty: LedgerAccount.GetLocalizedConstant(); } }
        public string LedgerTagTypeTranslated { get { return string.IsNullOrEmpty(LedgerTagType) ? string.Empty : LedgerTagType.GetLocalizedConstant(); } }
        public string Description { get; set; }
        public int? Number { get; set; }
        public long? DefaultVatId { get; set; }
        public long? LedgerTagGroupId { get; set; }
        public string LedgerTagGroupDescription { get; set; }
        public decimal? DefaultDeductionPercentage { get; set; }
        public string DefaultVatAbbreviation { get; set; }
        public string DefaultCurrencyAbbreviation { get; set; }
        public string DefaultCurrencyDescription
        {
            get { return DefaultCurrencyAbbreviation.GetLocalizedCurrencyName(); }
        }
        public string ShortDescription
        {
            get { return Number.HasValue ? Number.Value.ToString() : Description; }
        }
        public string LongDescription
        {
            get { return Number.HasValue ? string.Format("{0} - {1}", Number.Value, Description) : Description; }
        }

        public int? LedgerTagGroupIndex { get; set; }
    }
}