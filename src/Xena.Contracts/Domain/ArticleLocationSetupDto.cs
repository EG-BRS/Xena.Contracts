using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Xena.Contracts.Domain
{
    public class ArticleLocationSetupDto : EntityDto
    {
        public static ArticleLocationSetupDto CreateFromArticle(string articleNumber, string articleDescription, long? articleId)
        {
            return new ArticleLocationSetupDto
            {
                ArticleId = articleId,
                ArticleNumber = articleNumber,
                ArticleDescription = articleDescription,
            };
        }
        public static ArticleLocationSetupDto CreateFromLocation(string locationAbbreviation, string locationDescription, long? locationId)
        {
            return new ArticleLocationSetupDto
            {
                LocationId = locationId,
                LocationAbbreviation = locationAbbreviation,
                LocationDescription = locationDescription
            };
        }

        [Required]
        public long? ArticleId { get; set; }
        public long? ArticleVariantId { get; set; }
        public long? LocationId { get; set; }
        public decimal MinimumQuantity { get; set; }
        public decimal MaximumQuantity { get; set; }

        //Convinience properties
        [ReadOnly(true)]
        public string ArticleNumber { get; set; }
        [ReadOnly(true)]
        public string ArticleDescription { get; set; }
        [ReadOnly(true)]
        public string ArticleVariantAbbreviation { get; set; }
        [ReadOnly(true)]
        public string LocationAbbreviation { get; set; }
        [ReadOnly(true)]
        public string LocationDescription { get; set; }
    }
}