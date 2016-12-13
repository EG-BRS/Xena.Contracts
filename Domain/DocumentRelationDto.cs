namespace Xena.Contracts.Domain
{
    public class DocumentRelationDto : FiscalDto, IHasIdDto
    {
        public long? Id { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public long DocumentId { get; set; }
        public long RelationId { get; set; }
        public string Account { get; set; }
    }
}