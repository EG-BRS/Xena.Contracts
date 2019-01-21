namespace Xena.Contracts.Helpers
{
    public class XenaSubscriptionData
    {
        public long? XenaSubscriptionId { get; set; }
        public long? XenaSubscriptionTicketId { get; set; }
    }

    public class XenaValidPaymentData
    {
        public XenaValidPaymentData(bool hasValidPayment)
        {
            HasValidPayment = hasValidPayment;
        }
        public bool HasValidPayment { get; set; }
    }
}