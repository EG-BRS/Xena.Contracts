using System;
using System.IO;
using System.Linq;

namespace Xena.Contracts.Domain
{
    public class DocumentVersionDto : IHasIdDto
    {
        public string FileName { get; set; }
        public DateTime Created { get; set; }
        public string Note { get; set; }
        public long? Id { get; set; }
        public string ContentType { get; set; }
        public bool? HasPreview { get;set; }
        public int? PreviewPages { get;set; }
        public int? PageCount { get; set; }
        public bool IsInline { get; set; }

        public bool IsImage { get; set; }

        public bool IsPdf { get; set; }


    }
}