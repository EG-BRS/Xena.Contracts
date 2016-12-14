namespace Xena.Contracts.Domain
{
    public class XenaUserSubscriptionTicketDto : XenaUserDto
    {
        public long SubscriptionId { get; set; }
        public string CardNumberMasked { get; set; }
        public string CardTypeName { get; set; }
        public string LastErrorMessage { get; set; }
    }
}