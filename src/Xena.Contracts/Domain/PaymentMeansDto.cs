using System.ComponentModel;
using Xena.Common.Constants;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class PaymentMeansDto : EntityDto
    {
        public string PaymentMeansType { get; set; }
        public string Account { get; set; }
        public string AccountIdentifier { get; set; }
        public string BankName { get; set; }

        //Convinience properties
        private string _exampleIdentification = null;
        [ReadOnly(true)]
        public string ExampleIdentification
        {
            get
            {
                if (_exampleIdentification != null)
                {
                    return _exampleIdentification;
                }

                switch (PaymentMeansType)
                {
                    case PaymentMeansTypes.Bank:
                    case PaymentMeansTypes.DK_Bank:
                        return $"{BankName} {AccountIdentifier} {Account}";
                    case PaymentMeansTypes.DK_FIK_71:
                        return $"+71<ffffffkkkkkkkkc+{Account}";
                    case PaymentMeansTypes.DK_FIK_73:
                        return $"+73< +{Account}";
                    case PaymentMeansTypes.DK_FIK_75:
                        return $"+75<0ffffffkkkkkkkkc+{Account}";
                    case PaymentMeansTypes.DK_Giro_01:
                        return $"+01< +{Account}";
                    case PaymentMeansTypes.DK_Giro_04:
                        return $"+04<ffffffkkkkkkkkc+{Account}";
                    case PaymentMeansTypes.DK_Giro_15:
                        return $"+15<ffffffkkkkkkkkc+{Account}";
                    case PaymentMeansTypes.NO_Bank:
                        return $"{BankName} {Account}";
                    case PaymentMeansTypes.NO_Bank_Mod_10:
                    case PaymentMeansTypes.NO_Bank_Mod_11:
                        return $"KID NR. ffffffkkkkkkkkc KONTO NR. {Account}";
                    case PaymentMeansTypes.IBAN_NON_EU:
                        return $"IBAN: {AccountIdentifier} {Account}";
                    case PaymentMeansTypes.IBAN_SWIFT:
                        return $"SWIFT: {AccountIdentifier} IBAN: {Account}";
                    default:
                        return string.Empty;
                }
            }
            set { _exampleIdentification = value; }
        }

        private string _paymentMeansTypeTranslated = null;
        [ReadOnly(true)]
        public string PaymentMeansTypeTranslated
        {
            get
            {
                return _paymentMeansTypeTranslated ?? (string.IsNullOrEmpty(PaymentMeansType)
                           ? string.Empty
                           : PaymentMeansType.GetLocalizedConstant());
            }
            set { _paymentMeansTypeTranslated = value; }
        }
        private string _paymentMeansTypeHelp = null;
        [ReadOnly(true)]
        public string PaymentMeansTypeHelp
        {
            get
            {
                return _paymentMeansTypeHelp ?? (string.IsNullOrEmpty(PaymentMeansType)
                           ? string.Empty
                           : $"{PaymentMeansType}_Help".GetLocalizedConstant());
            }
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

        private bool? _allowsDefaultMessage = null;
        [ReadOnly(true)]
        public bool AllowsDefaultMessage
        {
            get { return _allowsDefaultMessage ?? PaymentMeansTypes.AllowsDefaultMessage(PaymentMeansType); }
            set { _allowsDefaultMessage = value; }
        }

        private bool? _allowsAccountIdentification = null;
        [ReadOnly(true)]
        public bool AllowsAccountIdentification
        {
            get { return _allowsAccountIdentification ?? PaymentMeansTypes.AllowsAccountIdentification(PaymentMeansType); }
            set { _allowsAccountIdentification = value; }
        }

        private string _accountLabelTranslated = null;
        [ReadOnly(true)]
        public string AccountLabelTranslated
        {
            get
            {
                return _accountLabelTranslated ?? (string.IsNullOrEmpty(PaymentMeansType)
                           ? string.Empty
                           : $"{PaymentMeansType}_AccountLabel".GetLocalizedConstant());
            }
            set { _accountLabelTranslated = value; }
        }
        private string _accountIdentifierLabelTranslated = null;
        [ReadOnly(true)]
        public string AccountIdentifierLabelTranslated
        {
            get
            {
                return _accountIdentifierLabelTranslated ?? (string.IsNullOrEmpty(PaymentMeansType)
                           ? string.Empty
                           : $"{PaymentMeansType}_AccountIdentifierLabel".GetLocalizedConstant());
            }
            set { _accountIdentifierLabelTranslated = value; }
        }
    }
}