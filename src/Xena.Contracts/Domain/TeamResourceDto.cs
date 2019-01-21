using System.ComponentModel.DataAnnotations;

namespace Xena.Contracts.Domain
{
    public class TeamResourceDto : IHasIdDto
    {
        public long ResourceId { get; set; }
        public string ResourceName { get; set; }
        public long? Id { get; set; }
    }
}