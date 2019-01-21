using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class VatDto : EntityDto
    {
        public string Abbreviation { get; set; }
        public string Description { get; set; }
        public decimal Percentage { get; set; }
        public string VatType { get; set; }

        private string _vatTypeTranslated = null;
        [ReadOnly(true)]
        public string VatTypeTranslated
        {
            get { return _vatTypeTranslated ?? (!string.IsNullOrEmpty(VatType) ? VatType.GetLocalizedConstant() : string.Empty); }
            set { _vatTypeTranslated = value; }
        }
        public long? ContraVatId { get; set; }
        public string ContraVatAbbreviation { get; set; }
        public string ContraVatDescription { get; set; }
        public int? LedgerAccount { get; set; }

        private string _shortDescription = null;
        [ReadOnly(true)]
        public string ShortDescription
        {
            get { return _shortDescription ?? (string.IsNullOrEmpty(Abbreviation) ? Abbreviation : Description); }
            set { _shortDescription = value; }
        }

        private string _longDescription = null;
        [ReadOnly(true)]
        public string LongDescription
        {
            get { return _longDescription ?? (string.IsNullOrEmpty(Abbreviation) ? string.Format("{0} - {1}", Abbreviation, Description) : Description); }
            set { _longDescription = value; }
        }
    }
}