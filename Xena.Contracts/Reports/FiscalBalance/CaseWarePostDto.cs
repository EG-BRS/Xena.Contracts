using Xena.Resources;

namespace Xena.Contracts.Reports.FiscalBalance
{
    public class CaseWarePostDto
    {
        public string FiscalDate { get; set; }
        public int VoucherNumber { get; set; }
        public int AccountNumber { get; set; }
        public string LedgerAccount { get; set; }
        public string LedgerAccountTranslated
        {
            get { return LedgerAccount.GetLocalizedConstant(); }
        }

        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string VATAbbreviation { get; set; }
        public decimal VATAmount { get; set; }
        public string Url { get; set; }
    }
}