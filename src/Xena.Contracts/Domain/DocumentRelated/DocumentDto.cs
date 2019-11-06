using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Xena.Contracts.Domain.DocumentRelated
{
    public class DocumentDto : IHasIdDto
    {
        public long? Id { get; set; }
        public int Version { get; set; }

        [ReadOnly(true)]
        public bool IsDeactivated { get; set; }

        [Required]
        public string Description { get; set; }

        //Convinience properties
        public string LastFileName { get; set; }
        [ReadOnly(true)]
        public int LastContentLength { get; set; }
        [ReadOnly(true)]
        public DateTime LastCreated { get; set; }
        [ReadOnly(true)]
        public long? LastVersionId { get; set; }
        [ReadOnly(true)]
        public string LastContentType { get; set; }
        [ReadOnly(true)]
        public string LastNote { get; set; }
        [ReadOnly(true)]
        public string LastFileFolder { get; set; }
        [ReadOnly(true)]
        public Guid LastFileId { get; set; }
        [ReadOnly(true)]
        public bool? HasPreview { get; set; }

        private bool? _isInline;
        [ReadOnly(true)]
        public bool IsInline
        {
            get { return _isInline ?? this.IsInline(); }
            set { _isInline = value; }
        }

        private bool? _isImage;
        [ReadOnly(true)]
        public bool IsImage
        {
            get { return _isImage ?? FileTypeHelper.GetExtension(LastFileName).IsImage(); }
            set { _isImage = value; }
        }

        private bool? _isInlinePdf;
        [ReadOnly(true)]
        public bool IsInlinePdf
        {
            get { return _isInlinePdf ?? FileTypeHelper.GetExtension(LastFileName).IsPdf(); }
            set { _isInlinePdf = value; }
        }
    }
}