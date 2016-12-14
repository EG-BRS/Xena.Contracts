

namespace Xena.Contracts.Helpers
{
    public class PaymentMeansTypeData
    {
        public PaymentMeansTypeData(string paymentMeansType)
        {
            PaymentMeansType = paymentMeansType;
        }

        public string PaymentMeansType { get; private set; }
        public string PaymentMeansTypeTranslated
        { get; set; }
        public string PaymentMeansTypeHelp
        { get; set; }
        public bool AllowsBankName
        { get; set; }
        public bool AllowsAccount
        { get; set; }
        public bool AllowsAccountIdentification
        { get; set; }
        public string AccountLabelTranslated
        { get; set; }
        public string AccountIdentifierLabelTranslated
        { get; set; }
    }
}