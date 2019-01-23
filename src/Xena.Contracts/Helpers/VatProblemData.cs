using System;
using System.ComponentModel;
using Xena.Contracts.Domain;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Helpers
{
    public class VatProblemData
    {
        public VatProblemData()
        {
            
        }

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

        private string _vatTypeTranslated = null;
        [ReadOnly(true)]
        public string VatTypeTranslated
        {
            get
            {
                return _vatTypeTranslated ??
                       (string.IsNullOrEmpty(VatType) ? string.Empty : VatType.GetLocalizedConstant());
            }
            set { _vatTypeTranslated = value; }
        }
    }
}