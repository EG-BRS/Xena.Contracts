using System.ComponentModel;

namespace Xena.Contracts.Domain
{
    public class DocumentRelationDto : FiscalDto, IHasIdDto
    {
        [ReadOnly(true)]
        public long? Id { get; set; }
        [ReadOnly(true)]
        public string Description { get; set; }
        [ReadOnly(true)]
        public string Type { get; set; }
        [ReadOnly(true)]
        public long DocumentId { get; set; }
        [ReadOnly(true)]
        public long RelationId { get; set; }
        [ReadOnly(true)]
        public string Account { get; set; }
    }
}