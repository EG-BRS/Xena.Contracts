using System.ComponentModel;

namespace Xena.Contracts.Domain
{
    public class ResourceInboxDocumentRelationDto : EntityDto
    {
        [ReadOnly(true)]
        public string Description { get; set; }
        [ReadOnly(true)]
        public long DocumentId { get; set; }
        [ReadOnly(true)]
        public long ResourceId { get; set; }
        public bool Parked { get; set; }
        public bool IsNew { get; set; }
        public string ParkedNote { get; set; }
    }
}