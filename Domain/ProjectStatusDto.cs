namespace Xena.Contracts.Domain
{
    public class ProjectStatusDto : EntityDto
    {
        public string Description { get; set; }
        public int Index { get; set; }
        public string Color { get; set; }
    }
}