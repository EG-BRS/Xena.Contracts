using Xena.Resources;

namespace Xena.Contracts.Reports.FiscalBalance
{
    public class CaseWareAccountDto
    {
        public int AccountNumber { get; set; }
        public string LedgerAccount { get; set; }
        public string LedgerAccountTranslated
        {
            get { return LedgerAccount.GetLocalizedConstant(); }
        }
        public string Description { get; set; }
        public string DefaultVAT { get; set; }
        public decimal BalancePrimo { get; set; }
        public string Url { get; set; }
    }
}