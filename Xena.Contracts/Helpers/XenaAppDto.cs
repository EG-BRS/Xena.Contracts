using Xena.Contracts.Domain;
using Xena.Resources;

namespace Xena.Contracts.Helpers
{
    public class XenaAppDto : EntityDto
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public string Uri { get; set; }
        public long? IconId { get; set; }
        public string ClientIdentifier { get; protected set; }
        public string ClientSecret { get; protected set; }
        public string Callback { get; set; }
        public int ClientType { get; protected set; }
        public string Category { get; set; }
        public string ApplicationVisibility { get; set; }
        public bool IsApproved { get; set; }

        public string Culture { get; set; }
        public bool IsCountrySpecific { get; set; }
        public string CountryName { get; set; }
        public decimal PricePerFiscal { get; set; }
        public decimal PricePerUser { get; set; }
        public string CultureDisplayName
        {
            get { return Culture.GetLocalizedCultureName(); }
        }
        public string CountryDisplayName
        {
            get { return string.IsNullOrEmpty(CountryName) ? string.Empty : CountryName.GetLocalizedCountryName(); }
        }

        public string CategoryTranslated
        {
            get { return string.IsNullOrEmpty(Category) ? string.Empty : Category.GetLocalizedConstant(); }
        }
        public string ApplicationVisibilityTranslated
        {
            get { return string.IsNullOrEmpty(ApplicationVisibility) ? string.Empty : ApplicationVisibility.GetLocalizedConstant(); }
        }
    }
}