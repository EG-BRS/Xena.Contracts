using System;
using System.ComponentModel;
using Xena.Common.ExtensionMethods;

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
        //Convinience properties
        [ReadOnly(true)]
        public DateTime ReceivedAt { get; set; }
        [ReadOnly(true)]
        public string VoucherPreviewPartnerName { get; set; }
        [ReadOnly(true)]
        public int? VoucherPreviewDateDays { get; set; }
        [ReadOnly(true)]
        public string VoucherPreviewDateFriendly => VoucherPreviewDateDays.FriendlyString();
    }
}