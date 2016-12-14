

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

        public string CountryDisplayName { get; set; }

        public string PlaceName { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
    }
}