namespace Xena.Contracts.Helpers
{
    public class XenaValidPaymentData
    {
        public XenaValidPaymentData(bool hasValidPayment)
        {
            HasValidPayment = hasValidPayment;
        }
        public bool HasValidPayment { get; set; }
    }
}