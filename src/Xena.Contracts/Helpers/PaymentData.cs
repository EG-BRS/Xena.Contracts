namespace Xena.Contracts.Helpers
{
    public class PaymentData
    {
        public PaymentDetailData[] Details { get; set; }
        public long ContextId { get; set; }
    }
}