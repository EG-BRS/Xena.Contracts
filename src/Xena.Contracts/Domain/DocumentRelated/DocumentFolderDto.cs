using System.ComponentModel;

namespace Xena.Contracts.Domain.DocumentRelated
{
    public class DocumentFolderDto : IHasIdDto
    {
        public long? Id { get; set; }
        public int Version { get; set; }

        [ReadOnly(true)]
        public bool IsDeactivated { get; set; }

        public string Name { get; set; }

        public int Order { get; set; }

        public string EntityType { get; set; }

        public long EntityId { get; set; }
    }
}