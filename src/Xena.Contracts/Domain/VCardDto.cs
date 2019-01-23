using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Xena.Common.Constants;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class VCardDto : IEntityDto
    {
        public VCardDto()
        {
            Provider = AddressProviders.Xena_VCard;
            TelephoneNumbers = new List<TelephoneNumberDto>();
            EmailContacts = new List<EmailContactDto>();
        }
        public long? Id { get; set; }
        public int Version { get; set; }
        public bool IsDeactivated { get; set; }
        public long? FiscalSetupId { get; set; }
        public string FiscalSetupName { get; set; }
        public DateTime CreatedAt { get; set; }

        public IList<EmailContactDto> EmailContacts { get; set; }
        public IList<TelephoneNumberDto> TelephoneNumbers { get; set; }
        private string _phoneNumber = null;
        [ReadOnly(true)]
        public string PhoneNumber
        {
            get { return _phoneNumber ?? (TelephoneNumbers.Any() ? TelephoneNumbers.First().Number : string.Empty); }
            set { _phoneNumber = value; }
        }
        private string _email = null;
        [ReadOnly(true)]
        public string Email
        {
            get { return _email ?? (EmailContacts.Any() ? EmailContacts.First().Email : string.Empty); }
            set { _email = value; }
        }
        public long? PictureId { get; set; }
        public long? ResourceId { get; set; }
        public long? UserId { get; set; }
        public long? PartnerId { get; set; }
        public string Provider { get; set; }

        private string _providerType = null;
        [ReadOnly(true)]
        public string ProviderType
        {
            get { return _providerType ?? (UserId.HasValue ? PartnerTypes.Xena_Person : PartnerTypes.Xena_Company); }
            set { _providerType = value; }
        }

        private string _providerTypeTranslated = null;
        [ReadOnly(true)]
        public string ProviderTypeTranslated
        {
            get { return _providerTypeTranslated ?? ProviderType.GetLocalizedConstant(); }
            set { _providerTypeTranslated = value; }
        }
        public string City { get; set; }
        public string CountryName { get; set; }

        private string _countryDisplayName = null;
        [ReadOnly(true)]
        public string CountryDisplayName
        {
            get { return _countryDisplayName ?? CountryName.GetLocalizedCountryName(); }
            set { _countryDisplayName = value; }
        }
        public string PlaceName { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string Name { get; set; }
    }
}