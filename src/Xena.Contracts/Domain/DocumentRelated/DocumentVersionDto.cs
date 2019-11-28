using System;
using System.ComponentModel;

namespace Xena.Contracts.Domain.DocumentRelated
{
    public class DocumentVersionDto : IHasIdDto
    {
        public string FileName { get; set; }
        public DateTime Created { get; set; }
        public string Note { get; set; }
        public long? Id { get; set; }
        public string ContentType { get; set; }
        public bool? HasPreview { get; set; }
        public int? PreviewPages { get; set; }
        public int? PageCount { get; set; }

        private bool? _isImage;
        [ReadOnly(true)]
        public bool IsImage
        {
            get { return _isImage ?? FileTypeHelper.GetExtension(FileName).IsImage(); }
            set { _isImage = value; }
        }

        private bool? _isPdf;
        [ReadOnly(true)]
        public bool IsPdf
        {
            get { return _isPdf ?? FileTypeHelper.GetExtension(FileName).IsPdf(); }
            set { _isPdf = value; }
        }

        private bool? _isXML;
        [ReadOnly(true)]
        public bool IsXml
        {
            get { return _isXML ?? FileTypeHelper.GetExtension(FileName).IsXML(); }
            set { _isXML = value; }
        }
    }
}