using System;
using System.IO;
using System.Linq;

namespace Xena.Contracts.Domain
{
    public class DocumentDto:IHasIdDto
    {
        public long? Id { get; set; }
        public string LastFileName { get; set; }
        public int LastContentLength { get; set; }
        public DateTime LastCreated { get; set; }
        public long? LastVersionId { get; set; }
        public bool IsDeactivated { get; set; }
        public string Description { get; set; }
        public string LastContentType { get; set; }
        public string LastNote { get; set; }
        public int Version { get; set; }
        public string LastFileFolder { get; set; }
        public Guid LastFileId { get; set; }

        public bool IsInline { get; set; }
        public bool CompatibleWithZoho { get; set; }

        public bool IsImage { get; set; }

        public bool IsInlinePdf { get; set; }


    }
}