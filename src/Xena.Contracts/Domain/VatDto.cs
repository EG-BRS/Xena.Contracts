

namespace Xena.Contracts.Domain
{
    public class VatDto : EntityDto
    {
        public string Abbreviation { get; set; }
        public string Description { get; set; }
        public decimal Percentage { get; set; }
        public string VatType { get; set; }

        public string VatTypeTranslated
        { get; set; }
        public long? ContraVatId { get; set; }
        public string ContraVatAbbreviation { get; set; }
        public string ContraVatDescription { get; set; }
        public int? LedgerAccount { get; set; }

        public string ShortDescription
        { get; set; }
        public string LongDescription
        { get; set; }
    }
}