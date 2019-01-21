namespace Xena.Contracts.Domain
{
    public class ProjectGroupDto : EntityDto
    {
        public string Description { get; set; }
        public decimal? MarginTarget { get; set; }
    }
}