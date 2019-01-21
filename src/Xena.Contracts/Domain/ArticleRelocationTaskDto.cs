using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Xena.Contracts.Domain
{
    public class ArticleRelocationTaskDto : EntityDto
    {
        [Required]
        public long ArticleId { get; set; }
        public long? ArticleVariantId { get; set; }
        public long? LocationFromId { get; set; }
        public long? LocationToId { get; set; }
        public decimal Quantity { get; set; }

        //Convinience properties
        [ReadOnly(true)]
        public string ArticleNumber { get; set; }
        [ReadOnly(true)]
        public string ArticleDescription { get; set; }
        [ReadOnly(true)]
        public string ArticleVariantAbbreviation { get; set; }
        [ReadOnly(true)]
        public string LocationFromAbbreviation { get; set; }
        [ReadOnly(true)]
        public string LocationToAbbreviation { get; set; }
    }
}