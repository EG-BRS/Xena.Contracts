using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class VatDto : EntityDto
    {
        public string Abbreviation { get; set; }
        public string Description { get; set; }
        public decimal Percentage { get; set; }
        public string VatType { get; set; }

        public string VatTypeTranslated
        {
            get { return !string.IsNullOrEmpty(VatType) ? VatType.GetLocalizedConstant() : string.Empty; }
        }
        public long? ContraVatId { get; set; }
        public string ContraVatAbbreviation { get; set; }
        public string ContraVatDescription { get; set; }
        public int? LedgerAccount { get; set; }

        public string ShortDescription
        {
            get { return string.IsNullOrEmpty(Abbreviation) ? Abbreviation : Description; }
        }
        public string LongDescription
        {
            get { return string.IsNullOrEmpty(Abbreviation) ? string.Format("{0} - {1}", Abbreviation, Description) : Description; }
        }
    }
}