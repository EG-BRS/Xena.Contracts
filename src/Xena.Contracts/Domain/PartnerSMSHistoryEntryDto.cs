using System;

namespace Xena.Contracts.Domain
{
    public class PartnerSMSHistoryEntryDto : EntityDto
    {
        public string PhoneNumber { get; set; }
        public long? PartnerId { get; set; }
        public long ResourceId { get; set; }
        public string Body { get; set; }
        public string Description { get; set; }
        public string SenderNumber { get; set; }
    }
}