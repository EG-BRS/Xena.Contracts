using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class BankPostingPartnerPostDto
    {
        //Convinience properties
        public long PartnerPostId { get; set; }
        public decimal Amount { get; set; }
        public decimal CurrencyAmount { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public string PostType { get; set; }
        public int DueDateDays { get; set; }
        public int FiscalDateDays { get; set; }
        public string SupplierInvoiceNumber { get; set; }
        private string _postTypeTranslated = null;
        [ReadOnly(true)]
        public string PostTypeTranslated
        {
            get { return _postTypeTranslated ?? PostType.GetLocalizedConstant(); }
            set { _postTypeTranslated = value; }
        }
    }
}