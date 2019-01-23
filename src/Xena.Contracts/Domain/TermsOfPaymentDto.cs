using System.ComponentModel;
using Xena.Common.Constants;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class TermsOfPaymentDto
    {
        public int Offset { get; set; }
        public string DueType { get; set; }
        private string _description = null;
        [ReadOnly(true)]
        public string Description
        {
            get
            {
                if (_description != null)
                {
                    return _description;
                }

                if (DueType == DueTypes.Xena_PrePaid)
                    return DueTypes.Xena_PrePaid.GetLocalizedDueType();
                if (DueType == DueTypes.Xena_Cash)
                    return DueTypes.Xena_Cash.GetLocalizedDueType();
                if (DueType == DueTypes.Xena_Nett)
                    return Offset == 0 ? DueTypes.Xena_Nett.GetLocalizedDueType() : string.Format(DueTypeDays.Xena_Nett_Days.GetLocalizedDueType(), Offset);
                return Offset == 0 ? DueTypes.Xena_RunningMonth.GetLocalizedDueType() : string.Format(DueTypeDays.Xena_RunningMonth_Days.GetLocalizedDueType(), Offset);
            }
            set { _description = value; }
        }
    }
}