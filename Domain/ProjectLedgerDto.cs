namespace Xena.Contracts.Domain
{
    public class ProjectLedgerDto : EntityDto
    {
        public string Description { get; set; }
        public long? ResponsibleId { get; set; }
        public string ResponsibleName { get; set; }
    }
}