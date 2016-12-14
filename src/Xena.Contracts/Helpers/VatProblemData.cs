using System;
using Xena.Contracts.Domain;


namespace Xena.Contracts.Helpers
{
    public class VatProblemData
    {
        public VatProblemData(VatDto vat)
        {
            VatId = vat.Id.Value;
            VatAbbreviation = vat.Abbreviation;
            VatDescription = vat.Description;
            VatType = vat.VatType;

        }

        public long VatId { get; set; }
        public string VatAbbreviation { get; set; }
        public string VatDescription { get; set; }
        public string Description { get; set; }
        public string VatType { get; set; }

        public string VatTypeTranslated
        { get; set; }
    }
}