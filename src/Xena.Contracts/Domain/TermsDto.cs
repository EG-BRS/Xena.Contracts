using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class TermsDto : EntityDto
    {
        [Required]
        [StringLength(255)]
        public string Description { get; set; }
        public string Details { get; set; }
        public string CountryName { get; set; }
        public string TermsType { get; set; }
        [ReadOnly(true)]
        public int? IsActiveFromDateDays { get; set; }
        public int? DeadLineDateDays { get; set; }
        private string _countryDisplayName = null;
        [ReadOnly(true)]
        public string CountryDisplayName
        {
            get { return _countryDisplayName ?? CountryName.GetLocalizedCountryName(); }
            set { _countryDisplayName = value; }
        }
        private string _termsTypeTranslated = null;
        [ReadOnly(true)]
        public string TermsTypeTranslated
        {
            get { return _termsTypeTranslated ?? TermsType.GetLocalizedConstant(); }
            set { _termsTypeTranslated = value; }
        }
    }
}