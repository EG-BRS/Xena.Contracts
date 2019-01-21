using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Xena.Contracts.Domain
{
    public class AdditionalArticleDto : EntityDto
    {
        [Required]
        public long? ArticleId { get; set; }
        public decimal Quantity { get; set; }
        public long? ChildArticleId { get; set; }
        //Convinience properties
        [ReadOnly(true)]
        public string ChildArticleNumber { get; set; }
        [ReadOnly(true)]
        public string ChildArticleDescription { get; set; }
    }
}