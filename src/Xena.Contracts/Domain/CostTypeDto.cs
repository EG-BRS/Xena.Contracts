
using System.ComponentModel.DataAnnotations;

namespace Xena.Contracts.Domain
{
    public class CostTypeDto : EntityDto
    {
        [Required]
        public string Description { get; set; }
        public decimal DefaultMargin { get; set; }
        public long? DefaultArticleGroupId { get; set; }
        public string DefaultArticleGroupDescription { get; set; }
    }
}