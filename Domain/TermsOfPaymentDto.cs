using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class TermsOfPaymentDto
    {
        public int Offset { get; set; }
        public string DueType { get; set; }
        public string Description
        {
            get
            {
                if (DueType == Constants.DueTypes.Xena_PrePaid)
                    return UI.Domain_TermsOfPayment_Description_PrePaid;
                if (DueType == Constants.DueTypes.Xena_Cash)
                    return UI.Domain_TermsOfPayment_Description_Cash;
                if (DueType == Constants.DueTypes.Xena_Nett)
                    return Offset == 0 ? UI.Domain_TermsOfPayment_Description_NettCash : string.Format(UI.Domain_TermsOfPayment_Description_NettCash_Days, Offset);
                return Offset == 0 ? UI.Domain_TermsOfPayment_Description_RunningMonth : string.Format(UI.Domain_TermsOfPayment_Description_RunningMonth_Days, Offset);
            }
        }
    }
}