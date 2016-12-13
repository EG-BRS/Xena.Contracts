using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class InvitedPartnerDto : IHasIdDto
    {
        public long? Id { get; set; }
        public long InvitingFiscalSetupId { get; set; }
        public string PartnerType { get; set; }
        public string PartnerTypeTranslated
        {
            get { return PartnerType.GetLocalizedConstant(); }
        }

        public string Name { get; set; }
        public string PlaceName { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string CountryName { get; set; }
        public string CountryDisplayName
        {
            get { return CountryName.GetLocalizedCountryName(); }
        }
        public long? ChosenVcardId{ get; set; }
        public long NotificationId{ get; set; }
        public bool CreateNewBasedOnInvitation { get; set; }
    }
}