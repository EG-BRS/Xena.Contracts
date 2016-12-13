using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class ArticleGroupVatSetupDto : EntityDto
    {
        public long ArticleGroupId { get; set; }
        public string ArticleGroupDescription { get; set; }
        public long? SalesVatId { get; set; }
        public string SalesVatAbbreviation { get; set; }
        public long? PurchasingVatId { get; set; }
        public string PurchasingVatAbbreviation { get; set; }
        public string CountryName { get; set; }
        public string CountryDisplayName
        {
            get { return CountryName.GetLocalizedCountryName(); }
        }
    }
}