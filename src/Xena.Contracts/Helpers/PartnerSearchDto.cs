

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
        public string ProviderId { get; set; }
        public bool SendInvite { get; set; } 
        public string CountryDisplayName { get; set; }
        public bool DefaultCustomer { get; set; }
        public bool DefaultSupplier { get; set; }
        public bool PartnerSuggestion { get; set; }
    }
}