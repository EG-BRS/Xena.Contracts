using System.ComponentModel;
using Xena.Contracts.Domain;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Helpers
{
    public class XenaAppBundleDto : EntityDto
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public string Uri { get; set; }
        public string Category { get; set; }
        public long? IconId { get; set; }

        public string Culture { get; set; }
        public bool IsCountrySpecific { get; set; }
        public string CountryName { get; set; }

        public decimal PricePerFiscal { get; set; }
        public decimal PricePerUser { get; set; }

        //Convinience properties
        [ReadOnly(true)]
        public bool IsApproved { get; set; }
        [ReadOnly(true)]
        public bool IsAwaitingApproval { get; set; }
        private string _cultureDisplayName = null;
        [ReadOnly(true)]
        public string CultureDisplayName
        {
            get { return _cultureDisplayName ?? Culture.GetLocalizedCultureName(); }
            set { _cultureDisplayName = value; }
        }
        private string _countryDisplayName = null;
        [ReadOnly(true)]
        public string CountryDisplayName
        {
            get
            {
                return _countryDisplayName ?? (string.IsNullOrEmpty(CountryName)
                           ? string.Empty
                           : CountryName.GetLocalizedCountryName());
            }
            set { _countryDisplayName = value; }
        }
        private string _categoryTranslated = null;
        [ReadOnly(true)]
        public string CategoryTranslated
        {
            get
            {
                return _categoryTranslated ??
                       (string.IsNullOrEmpty(Category) ? string.Empty : Category.GetLocalizedConstant());
            }
            set { _categoryTranslated = value; }
        }
        public string TermsMarkdown { get; set; }
    }
}