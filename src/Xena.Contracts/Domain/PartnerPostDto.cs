using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class PartnerPostDto : TransactionalDto
    {
        public string SupplierInvoiceNumber { get; set; }
        public decimal RunningTotal { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public decimal CurrencyAmount { get; set; }
        public int DueDateDays { get; set; }
        public int FiscalDateDays { get; set; }
        public long PartnerId { get; set; }
        public int PartnerAccountNumber { get; set; }
        public string PartnerName { get; set; }
        public string PostType { get; set; }
        public long VoucherId { get; set; }
        public int? VoucherNumber { get; set; }
        public long? EconomicTransactionId { get; set; }
        public long? PaymentExportedId { get; set; }
        public long? SettlementId { get; set; }
        public long? LedgerLineId { get; set; }
        //Convinience properties
        private string _dueDateDaysFriendly = null;
        [ReadOnly(true)]
        public string DueDateDaysFriendly
        {
            get { return _dueDateDaysFriendly ?? DueDateDays.FriendlyString(); }
            set { _dueDateDaysFriendly = value; }
        }
        private string _fiscalDateDaysFriendly = null;
        [ReadOnly(true)]
        public string FiscalDateDaysFriendly // => FiscalDateDays.FriendlyString();
        {
            get { return _fiscalDateDaysFriendly ?? FiscalDateDays.FriendlyString(); }
            set { _fiscalDateDaysFriendly = value; }
        }
        private string _postTypeTranslated = null;
        [ReadOnly(true)]
        public string PostTypeTranslated
        {
            get { return _postTypeTranslated ?? PostType.GetLocalizedConstant(); }
            set { _postTypeTranslated = value; }
        }
        public string PaymentIdentification { get; set; }
        public long? PrimoPartnerPostId { get; set; }
    }
}