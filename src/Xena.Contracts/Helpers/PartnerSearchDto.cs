using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Helpers
{
    public class PartnerSearchDto
    {
        public long? FiscalSetupId { get; set; }
        public long? ResourceId { get; set; }
        public long? UserId { get; set; }
        public long? PartnerId { get; set; }
        public string Provider { get; set; }
        public string PartnerType { get; set; }
        public string City { get; set; }
        public string CountryName { get; set; }
        public string PlaceName { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Attention { get; set; }
        public string AvatarURL { get; set; }
        public string FiscalSetupName { get; set; }
        public string OrgNumber { get; set; }
        public string GLNNumber { get; set; }
        public string ProviderId { get; set; }
        public bool SendInvite { get; set; }
        private string _countryDisplayName = null;
        [ReadOnly(true)]
        public string CountryDisplayName
        {
            get { return _countryDisplayName ?? CountryName.GetLocalizedCountryName(); }
            set { _countryDisplayName = value; }
        }
        public bool IsCustomer { get; set; }
        public bool IsSupplier { get; set; }
        public string CustomerTermsOfPaymentDueType { get; set; }
        public  int? CustomerTermsOfPaymentOffset { get; set; }
        public string SupplierTermsOfPaymentDueType { get; set; }
        public  int? SupplierTermsOfPaymentOffset { get; set; }
    }
}