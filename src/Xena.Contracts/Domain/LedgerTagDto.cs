

namespace Xena.Contracts.Domain
{
    public class LedgerTagDto : EntityDto
    {
        public string LedgerAccount { get; set; }
        public string LedgerTagType { get; set; }
        public string LedgerAccountTranslated { get; set; }
        public string LedgerTagTypeTranslated { get; set; }
        public string Description { get; set; }
        public int? Number { get; set; }
        public long? DefaultVatId { get; set; }
        public long? LedgerTagGroupId { get; set; }
        public string LedgerTagGroupDescription { get; set; }
        public decimal? DefaultDeductionPercentage { get; set; }
        public string DefaultVatAbbreviation { get; set; }
        public string DefaultCurrencyAbbreviation { get; set; }
        public string DefaultCurrencyDescription
        { get; set; }
        public string ShortDescription
        { get; set; }
        public string LongDescription
        { get; set; }

        public int? LedgerTagGroupIndex { get; set; }
    }
}