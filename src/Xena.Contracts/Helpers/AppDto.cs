using System.ComponentModel;
using Xena.Contracts.Domain;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Helpers
{
    public class AppDto : IHasIdDto
    {
        [ReadOnly(true)]
        public long? Id { get; set; }
        [ReadOnly(true)]
        public string Name { get; set; }
        [ReadOnly(true)]
        public string Description { get; set; }
        [ReadOnly(true)]
        public string Details { get; set; }
        [ReadOnly(true)]
        public string ApplicationVisibility { get; set; }
        [ReadOnly(true)]
        public long CreatorId { get; set; }
        [ReadOnly(true)]
        public string CreatorName { get; set; }
        [ReadOnly(true)]
        public string ExternalUri { get; set; }
        [ReadOnly(true)]
        public long? IconId { get; set; }
        [ReadOnly(true)]
        public string Category { get; set; }
        [ReadOnly(true)]
        public string TermsMarkdown { get; set; }
        [ReadOnly(true)]
        public string Culture { get; set; }
        [ReadOnly(true)]
        public bool IsCountrySpecific { get; set; }
        [ReadOnly(true)]
        public bool IsApproved { get; set; }
        [ReadOnly(true)]
        public bool IsAwaitingApproval { get; set; }
        [ReadOnly(true)]
        public string CountryName { get; set; }
        [ReadOnly(true)]
        public decimal PricePerFiscal { get; set; }
        [ReadOnly(true)]
        public decimal PricePerUser { get; set; }
        [ReadOnly(true)]
        public bool IsBundle { get; set; }
        private string _applicationVisibilityTranslated = null;
        [ReadOnly(true)]
        public string ApplicationVisibilityTranslated
        {
            get
            {
                return _applicationVisibilityTranslated ?? (string.IsNullOrEmpty(ApplicationVisibility)
                           ? string.Empty
                           : ApplicationVisibility.GetLocalizedConstant());
            }
            set { _applicationVisibilityTranslated = value; }
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
            get { return _countryDisplayName ?? CountryName.GetLocalizedCountryName(); }
            set { _countryDisplayName = value; }
        }
    }
}