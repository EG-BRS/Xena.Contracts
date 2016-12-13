using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class AddressDto
    {
        public AddressDto()
        {
        }

        public AddressDto(PartnerResourceContextDto resource)
        {
            City = resource.City;
            CountryName = resource.CountryName;
            PlaceName = resource.PlaceName;
            Street = resource.Street;
            Zip = resource.Zip;
            Name = resource.Name;
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

        public string Description
        {
            get
            {
                return string.IsNullOrEmpty(Name)
                    ? string.Format("{0} - {1} {2}", Street, Zip, City)
                    : string.Format("{0} - {1}, {2} {3}", Name, Street, Zip, City);
            }
        }
    }
}