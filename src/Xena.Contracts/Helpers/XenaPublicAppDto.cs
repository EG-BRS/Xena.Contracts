using Xena.Contracts.Domain;


namespace Xena.Contracts.Helpers
{
    public class XenaPublicAppDto : IHasIdDto
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public string ApplicationVisibility { get; set; }

        public string ApplicationVisibilityTranslated
        { get; set; }
        public long CreatorId { get; set; }
        public string CreatorName { get; set; }
        public int NoOfUsers { get; set; } //Hvor mange resourcer har installeret den
        public string ExternalUri { get; set; }
        public long? IconId { get; set; }
        public string Category { get; set; }
        public string CategoryTranslated
        { get; set; }
        public string Culture { get; set; }
        public bool IsCountrySpecific { get; set; }
        public bool IsApproved { get; set; }
        public string CountryName { get; set; }
        public decimal PricePerFiscal { get; set; }
        public decimal PricePerUser { get; set; }
        public string CultureDisplayName
        { get; set; }
        public string CountryDisplayName
        { get; set; }
        public long? UserArticleId { get; set; }
        public string UserArticleNumber { get; set; }
        public long? FiscalArticleId { get; set; }
        public string FiscalArticleNumber { get; set; }
        public bool IsXenaApp { get; set; }
    }
}