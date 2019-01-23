using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Xena.Contracts.Domain
{
    public class TeamDto : EntityDto
    {
        public TeamDto()
        {
            Resources = new List<TeamResourceDto>();
        }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public IList<TeamResourceDto> Resources { get; set; }
    }
}