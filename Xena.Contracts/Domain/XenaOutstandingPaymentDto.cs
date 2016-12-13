namespace Xena.Contracts.Domain
{
    public class XenaOutstandingPaymentDto
    {
        public long Id { get; set; }
        public long SubscriptionId { get;  set; }
        public long OrderInvoiceTransactionId { get;  set; }
    }
}