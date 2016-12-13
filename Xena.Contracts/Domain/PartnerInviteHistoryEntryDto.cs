using System;

namespace Xena.Contracts.Domain
{
    public class PartnerInviteHistoryEntryDto : EntityDto
    {
        public long? PartnerId { get; set; }
        public long ResourceId { get; set; }
        public string Body { get; set; }
        public string Description { get; set; }
        public string EmailId { get; set; }
        public string Email { get; set; } 
    }
}