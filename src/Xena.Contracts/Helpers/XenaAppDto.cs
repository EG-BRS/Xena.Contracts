using Xena.Contracts.Domain;


namespace Xena.Contracts.Helpers
{
    public class XenaAppDto : EntityDto
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public string Uri { get; set; }
        public long? IconId { get; set; }
        public string ClientIdentifier { get; protected set; }
        public string ClientSecret { get; protected set; }
        public string Callback { get; set; }
        public int ClientType { get; protected set; }
        public string Category { get; set; }
        public string ApplicationVisibility { get; set; }
        public bool IsApproved { get; set; }

        public string Culture { get; set; }
        public bool IsCountrySpecific { get; set; }
        public string CountryName { get; set; }
        public decimal PricePerFiscal { get; set; }
        public decimal PricePerUser { get; set; }
        public string CultureDisplayName
        { get; set; }
        public string CountryDisplayName
        { get; set; }

        public string CategoryTranslated
        { get; set; }
        public string ApplicationVisibilityTranslated
        { get; set; }
    }
}