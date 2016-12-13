using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class PaymentMeansDto : EntityDto
    {
        public string PaymentMeansType { get; set; }
        public string Account { get; set; }
        public string AccountIdentifier { get; set; }
        public string BankName { get; set; }

        public string ExampleIdentification
        {
            get {
                switch (PaymentMeansType)
                {
                    case PaymentMeansTypes.Bank:
                    case PaymentMeansTypes.DK_Bank:
                        return string.Format("{0} {1} {2}", BankName, AccountIdentifier, Account);
                    case PaymentMeansTypes.DK_FIK_71:
                        return string.Format("+71<ffffffkkkkkkkkc+{0}", Account);
                    case PaymentMeansTypes.DK_FIK_73:
                        return string.Format("+73< +{0}", Account);
                    case PaymentMeansTypes.DK_FIK_75:
                        return string.Format("+75<0ffffffkkkkkkkkc+{0}", Account);
                    case PaymentMeansTypes.DK_Giro_01:
                        return string.Format("+01< +{0}", Account);
                    case PaymentMeansTypes.DK_Giro_04:
                        return string.Format("+04<ffffffkkkkkkkkc+{0}", Account);
                    case PaymentMeansTypes.DK_Giro_15:
                        return string.Format("+15<ffffffkkkkkkkkc+{0}", Account);
                    case PaymentMeansTypes.NO_Bank:
                        return string.Format("{0} {1}", BankName, Account);
                    case PaymentMeansTypes.NO_Bank_Mod_10:
                    case PaymentMeansTypes.NO_Bank_Mod_11:
                        return string.Format("KID NR. ffffffkkkkkkkkc KONTO NR. {0}", Account);
                    case PaymentMeansTypes.IBAN_NON_EU:
                        return string.Format("IBAN: {0} {1}", AccountIdentifier, Account);
                    case PaymentMeansTypes.IBAN_SWIFT:
                        return string.Format("SWIFT: {0} IBAN: {1}", AccountIdentifier, Account);
                    default:
                        return string.Empty;
                }
            }
        }
        public string PaymentMeansTypeTranslated
        {
            get { return string.IsNullOrEmpty(PaymentMeansType) ? string.Empty : PaymentMeansType.GetLocalizedConstant(); }
        }
        public string PaymentMeansTypeHelp
        {
            get { return string.IsNullOrEmpty(PaymentMeansType) ? string.Empty : string.Format("{0}_Help", PaymentMeansType).GetLocalizedConstant(); }
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
            get { return string.IsNullOrEmpty(PaymentMeansType) ? string.Empty : string.Format("{0}_AccountLabel", PaymentMeansType).GetLocalizedConstant(); }
        }
        public string AccountIdentifierLabelTranslated
        {
            get { return string.IsNullOrEmpty(PaymentMeansType) ? string.Empty : string.Format("{0}_AccountIdentifierLabel", PaymentMeansType).GetLocalizedConstant(); }
        }
    }
}