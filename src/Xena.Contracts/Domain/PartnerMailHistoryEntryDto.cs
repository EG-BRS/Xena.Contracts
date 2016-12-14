using System;
using System.Collections.Generic;

namespace Xena.Contracts.Domain
{
    public class PartnerMailHistoryEntryDto : EntityDto
    {
        public long? PartnerId { get; set; }
        public long? ResourceId { get; set; }
        public string Body { get; set; }
        public string Description { get; set; }
        public string EmailIdentifier { get; set; }
        public string InReplyTo { get; set; }
        public string FromEmailAddress { get; set; }
        public string ReceivedByEmailAddress { get; set; }
        public IList<string> ToEmailAddress { get; set; }
        public IList<string> CcEmailAddress { get; set; }
        public IList<string> BccEmailAddress { get; set; }
    }
}