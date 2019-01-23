using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Reports.FiscalBalance
{
    public class CaseWareAccountDto
    {
        public int AccountNumber { get; set; }
        public string LedgerAccount { get; set; }
        private string _ledgerAccountTranslated = null;
        [ReadOnly(true)]
        public string LedgerAccountTranslated
        {
            get { return _ledgerAccountTranslated ?? LedgerAccount.GetLocalizedConstant(); }
            set { _ledgerAccountTranslated = value; }
        }
        public string Description { get; set; }
        public string DefaultVAT { get; set; }
        public decimal BalancePrimo { get; set; }
        public string Url { get; set; }
    }
}