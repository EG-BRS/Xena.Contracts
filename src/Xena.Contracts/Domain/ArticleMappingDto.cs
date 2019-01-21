using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Xena.Contracts.Domain
{
    public class ArticleMappingDto : EntityDto
    {
        public ArticleMappingDto()
        {
        }
        public ArticleMappingDto(string articleDescription, string articleNumber, bool articleHasVariants)
        {
            ArticleDescription = articleDescription;
            ArticleNumber = articleNumber;
            ArticleHasVariants = articleHasVariants;
        }

        public ArticleMappingDto(int? partnerAccountNumber, string partnerName)
        {
            PartnerAccountNumber = partnerAccountNumber;
            PartnerName = partnerName;
        }

        public long? ArticleId { get; set; }
        public long? ArticleVariantId { get; set; }
        public long? PartnerId { get; set; }
        [Range(0,99999999999999)]
        public decimal Quantity { get; set; }
        public long? UnitId { get; set; }
        [Required]
        [StringLength(255, MinimumLength = 1)]
        public string PartnerArticleNumber { get; set; }
        [Required]
        public string PartnerArticleDescription { get; set; }

        //Convinience properties
        [ReadOnly(true)]
        public string ArticleNumber { get; set; }
        [ReadOnly(true)]
        public string ArticleDescription { get; set; }
        [ReadOnly(true)]
        public bool? ArticleHasVariants { get; set; }
        [ReadOnly(true)]
        public bool ArticleHasInventoryManagement { get; set; }
        [ReadOnly(true)]
        public string ArticleVariantAbbreviation { get; set; }

        private string _articleAbbreviation;
        [ReadOnly(true)]
        public string ArticleAbbreviation
        {
            get
            {
                return _articleAbbreviation ?? (string.IsNullOrEmpty(ArticleVariantAbbreviation)
                           ? ArticleNumber
                           : $"{ArticleNumber}-{ArticleVariantAbbreviation}");
            }
            set { _articleAbbreviation = value; }
        }

        [ReadOnly(true)]
        public string PartnerName { get; set; }
        [ReadOnly(true)]
        public int? PartnerAccountNumber { get; set; }
        [ReadOnly(true)]
        public string UnitAbbreviation { get; set; }
    }
}