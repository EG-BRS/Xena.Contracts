using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class UserProfileDto
    {
        public long Id { get; set; }
        public int Version { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string PlaceName { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string CountryDisplayName
        {
            get { return Country.GetLocalizedCountryName(); }
        }
        public string Culture { get; set; }
        public string CultureDisplayName
        {
            get { return Culture.GetLocalizedCultureName(); } 
        }
        public string UserName { get; set; }
        public string ConfirmedPhoneNumber { get; set; }
    }
}