namespace Xena.Contracts.Domain
{
    public class XenaFiscalSubscriptionTicketDto : XenaFiscalDto
    {
        public long SubscriptionId { get; set; }
        public string CardNumberMasked { get; set; }
        public string CardTypeName { get; set; }
        public string LastErrorMessage { get; set; }
    }
}