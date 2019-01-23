
using System.ComponentModel.DataAnnotations;

namespace Xena.Contracts.Domain
{
    public class ResourceTeamDto : IHasIdDto
    {
        [Required]
        public long TeamId { get; set; }
        public string TeamName { get; set; }
        public long? Id { get; set; }
    }
}