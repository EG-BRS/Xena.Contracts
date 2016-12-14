using System;


namespace Xena.Contracts.Domain
{
    public class PartnerHistoryEntryDto : EntityDto
    {
        public long? PartnerId { get; set; }
        public long ResourceId { get; set; }
        public string Body { get; set; }
        public string Description { get; set; }
        public string ResourceName { get; set; }
        public string EntryType { get; set; }
        public string EntryTypeTranslated { get; set; }
    }
}