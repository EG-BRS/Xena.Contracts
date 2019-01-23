using System.ComponentModel;
using Xena.Common.Constants;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Helpers
{
    public class PaymentMeansTypeData
    {
        public PaymentMeansTypeData()
        {
            
        }
        public PaymentMeansTypeData(string paymentMeansType)
        {
            PaymentMeansType = paymentMeansType;
        }

        public string PaymentMeansType { get; }
        private string _paymentMeansTypeTranslated = null;
        [ReadOnly(true)]
        public string PaymentMeansTypeTranslated
        {
            get { return _paymentMeansTypeTranslated ?? PaymentMeansType.GetLocalizedConstant(); }
            set { _paymentMeansTypeTranslated = value; }
        }
        private string _paymentMeansTypeHelp = null;
        [ReadOnly(true)]
        public string PaymentMeansTypeHelp
        {
            get { return _paymentMeansTypeHelp ?? $"{PaymentMeansType}_Help".GetLocalizedConstant(); }
            set { _paymentMeansTypeHelp = value; }
        }
        private bool? _allowsBankName = null;
        [ReadOnly(true)]
        public bool AllowsBankName
        {
            get { return _allowsBankName ?? PaymentMeansTypes.AllowsBankName(PaymentMeansType); }
            set { _allowsBankName = value; }
        }
        private bool? _allowsAccount = null;
        [ReadOnly(true)]
        public bool AllowsAccount
        {
            get { return _allowsAccount ?? PaymentMeansTypes.AllowsAccount(PaymentMeansType); }
            set { _allowsAccount = value; }
        }
        private bool? _allowsAccountIdentification = null;
        [ReadOnly(true)]
        public bool AllowsAccountIdentification
        {
            get { return _allowsAccountIdentification ?? PaymentMeansTypes.AllowsAccountIdentification(PaymentMeansType); }
            set { _allowsAccountIdentification = value; }
        }
        private bool? _allowsDefaultMessage = null;
        [ReadOnly(true)]
        public bool AllowsDefaultMessage
        {
            get { return _allowsDefaultMessage ?? PaymentMeansTypes.AllowsDefaultMessage(PaymentMeansType); }
            set { _allowsDefaultMessage = value; }
        }
        private string _accountLabelTranslated = null;
        [ReadOnly(true)]
        public string AccountLabelTranslated
        {
            get { return _accountLabelTranslated ?? $"{PaymentMeansType}_AccountLabel".GetLocalizedConstant(); }
            set { _accountLabelTranslated = value; }
        }
        private string _accountIdentifierLabelTranslated = null;
        [ReadOnly(true)]
        public string AccountIdentifierLabelTranslated
        {
            get { return _accountIdentifierLabelTranslated ?? $"{PaymentMeansType}_AccountIdentifierLabel".GetLocalizedConstant(); }
            set { _accountIdentifierLabelTranslated = value; }
        }
    }
}