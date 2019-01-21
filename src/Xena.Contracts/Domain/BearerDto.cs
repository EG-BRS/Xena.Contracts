using System.ComponentModel.DataAnnotations;

namespace Xena.Contracts.Domain
{
    public class BearerDto : EntityDto
    {
        [Required]
        public string Description { get; set; }
    }
}