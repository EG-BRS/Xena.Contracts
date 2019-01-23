using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class InvitedPartnerDto : IHasIdDto
    {
        public long? Id { get; set; }
        public long InvitingFiscalSetupId { get; set; }
        public string PartnerType { get; set; }
        public string Name { get; set; }
        public string PlaceName { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string City { get;  set; }
        public string CountryName { get; set; }
        public long? ChosenVcardId{ get; set; }
        public long NotificationId{ get; set; }
        public bool CreateNewBasedOnInvitation { get; set; }

        //Convinience properties
        private string _partnerTypeTranslated = null;
        [ReadOnly(true)]
        public string PartnerTypeTranslated
        {
            get { return _partnerTypeTranslated ?? PartnerType.GetLocalizedConstant(); }
            set { _partnerTypeTranslated = value; }
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