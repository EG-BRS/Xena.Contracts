using System;

namespace Xena.Contracts.Domain
{
    public class SubscriptionTicketDto : IHasIdDto
    {
        public long? Id { set; get; }
        public long SubscriptionId { get; set; }
        public string TicketId { get; set; }
        public string CardNumberMasked { get; set; }
        public string CardTypeName { get; set; }
        public long FiscalSetupId { get; set; }
        public DateTime CreatedAt { get; set; }
        public  string LastErrorMessage { get; set; }
    }
}