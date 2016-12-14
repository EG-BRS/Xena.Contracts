

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