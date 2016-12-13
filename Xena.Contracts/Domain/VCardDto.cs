using System;
using System.Collections.Generic;
using System.Linq;
using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class VCardDto : IEntityDto
    {
        public VCardDto()
        {
            Provider = Constants.AddressProviders.Xena_VCard;
            TelephoneNumbers = new List<TelephoneNumberDto>();
            EmailContacts = new List<EmailContactDto>();
        }
        public long? Id { get; set; }
        public int Version { get; set; }
        public bool IsDeactivated { get; set; }
        public long? FiscalSetupId { get; set; }
        public string FiscalSetupName { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        public IList<EmailContactDto> EmailContacts { get; set; }
        public IList<TelephoneNumberDto> TelephoneNumbers { get; set; }
        public string PhoneNumber
        {
            get { return TelephoneNumbers.Any() ? TelephoneNumbers.First().Number : string.Empty; }
        }
        public string Email
        {
            get { return EmailContacts.Any() ? EmailContacts.First().Email : string.Empty; }
        }
        public long? PictureId { get; set; }
        public long? ResourceId { get; set; }
        public long? UserId { get; set; }
        public long? PartnerId { get; set; }
        public string Provider { get; set; }

        public string ProviderType
        {
            get
            {
                return UserId.HasValue ? Constants.PartnerTypes.Xena_Person: Constants.PartnerTypes.Xena_Company;
            } 
        }

        public string ProviderTypeTranslated
        {
            get { return ProviderType.GetLocalizedConstant(); }
        }
        public string City { get; set; }
        public string CountryName { get; set; }
        public string CountryDisplayName
        {
            get { return CountryName.GetLocalizedCountryName(); }
        }
        public string PlaceName { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string Name { get; set; }
    }
}