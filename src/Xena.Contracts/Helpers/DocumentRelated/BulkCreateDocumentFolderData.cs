using System.Collections.Generic;
using Xena.Contracts.Domain.DocumentRelated;

namespace Xena.Contracts.Helpers.DocumentRelated
{
    public class BulkCreateDocumentFolderData
    {
        public long EntityId { get; set; }
        public string EntityType { get; set; }
        public IEnumerable<DocumentFolderDto> DocumentFolders { get; set; }
    }
}