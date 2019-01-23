using System.ComponentModel.DataAnnotations;

namespace Xena.Contracts.Domain
{
    public class DepartmentDto : EntityDto
    {
        [Required]
        public string Description { get; set; }
    }
}