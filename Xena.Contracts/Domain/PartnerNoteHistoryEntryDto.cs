using System;

namespace Xena.Contracts.Domain
{
    public class PartnerNoteHistoryEntryDto : EntityDto
    {
        public long? PartnerId { get; set; }
        public long ResourceId { get; set; }
        public string ResourceName { get; set; }
        public string Body { get; set; }
        public string Description { get; set; }
    }
}