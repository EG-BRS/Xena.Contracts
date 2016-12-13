using Xena.Resources;

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
        {
            get { return PaymentMeansType.GetLocalizedConstant(); }
        }
        public string PaymentMeansTypeHelp
        {
            get { return string.Format("{0}_Help", PaymentMeansType).GetLocalizedConstant(); }
        }
        public bool AllowsBankName
        {
            get { return PaymentMeansTypes.AllowsBankName(PaymentMeansType); }
        }
        public bool AllowsAccount
        {
            get { return PaymentMeansTypes.AllowsAccount(PaymentMeansType); }
        }
        public bool AllowsAccountIdentification
        {
            get { return PaymentMeansTypes.AllowsAccountIdentification(PaymentMeansType); }
        }
        public string AccountLabelTranslated
        {
            get { return string.Format("{0}_AccountLabel", PaymentMeansType).GetLocalizedConstant(); }
        }
        public string AccountIdentifierLabelTranslated
        {
            get { return string.Format("{0}_AccountIdentifierLabel", PaymentMeansType).GetLocalizedConstant(); }
        }
    }
}