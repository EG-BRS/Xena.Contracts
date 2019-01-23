using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Reports.FiscalBalance
{
    public class CaseWarePostDto
    {
        public string FiscalDate { get; set; }
        public int VoucherNumber { get; set; }
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
        public decimal Amount { get; set; }
        public string VATAbbreviation { get; set; }
        public decimal VATAmount { get; set; }
        public string Url { get; set; }
        public long? DepartmentId { get; set; }
        public string DepartmentDescription { get; set; }
        public long? BearerId { get; set; }
        public string BearerDescription { get; set; }
        public long? PurposeId { get; set; }
        public string PurposeDescription { get; set; }
        public long? ArticleGroupId { get; set; }
        public string ArticleGroupDescription { get; set; }
    }
}