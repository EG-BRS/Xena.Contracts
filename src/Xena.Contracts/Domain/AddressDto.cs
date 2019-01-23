using Xena.Common.ExtensionMethods;

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
        public string PlaceName { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string Name { get; set; }
        //Convinience properties
        public string Description => string.IsNullOrEmpty(Name)
            ? $"{Street} - {Zip} {City}"
            : $"{Name} - {Street}, {Zip} {City}";

        private string _countryDisplayName = null;
        public string CountryDisplayName
        {
            get { return _countryDisplayName ?? CountryName.GetLocalizedCountryName(); }
            set { _countryDisplayName = value; }
        }
    }
}