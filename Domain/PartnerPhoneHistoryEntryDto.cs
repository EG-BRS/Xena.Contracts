using System;

namespace Xena.Contracts.Domain
{
    public class PartnerPhoneHistoryEntryDto : EntityDto
    {
        public decimal DurationInMinutes { get; set; }
        public string PhoneNumber { get; set; }
        public string CallIdentifier { get; set; }
        public long? PartnerId { get; set; }
        public long ResourceId { get; set; }
        public string Body { get; set; }
        public string Description { get; set; }
    }
}