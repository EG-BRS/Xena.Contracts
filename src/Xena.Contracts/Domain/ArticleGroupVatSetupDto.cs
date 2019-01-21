using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class ArticleGroupVatSetupDto : EntityDto
    {

        public ArticleGroupVatSetupDto()
        {
        }


        public ArticleGroupVatSetupDto(string articleGroupDescription, string purchasingVatAbbreviation, string salesVatAbbreviation)
        {
            ArticleGroupDescription = articleGroupDescription;
            PurchasingVatAbbreviation = purchasingVatAbbreviation;
            SalesVatAbbreviation = salesVatAbbreviation;
        }

        [Required]
        public long ArticleGroupId { get; set; }
        public long? SalesVatId { get; set; }
        public long? PurchasingVatId { get; set; }
        [Required]
        [StringLength(3)]
        public string CountryName { get; set; }

        //Convinience properties
        [ReadOnly(true)]
        public string SalesVatAbbreviation { get; set; }
        [ReadOnly(true)]
        public string ArticleGroupDescription { get; set; }
        [ReadOnly(true)]
        public string PurchasingVatAbbreviation { get; set; }
        private string _countryDisplayName = null;
        public string CountryDisplayName
        {
            get { return _countryDisplayName ?? CountryName.GetLocalizedCountryName(); }
            set { _countryDisplayName = value; }
        }
    }
}