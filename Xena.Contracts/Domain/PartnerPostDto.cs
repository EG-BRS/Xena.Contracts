using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class PartnerPostDto : TransactionalDto
    {
        public decimal Amount { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public decimal CurrencyAmount { get; set; }
        public int DueDateDays { get; set; }
        public string DueDateDaysFriendly
        {
            get { return DueDateDays.FriendlyString(); }
        }
        public int FiscalDateDays { get; set; }
        public string FiscalDateDaysFriendly
        {
            get { return FiscalDateDays.FriendlyString(); }
        }
        public long PartnerId { get; set; }
        public int PartnerAccountNumber { get; set; }
        public string SupplierInvoiceNumber { get; set; }
        public string PartnerName { get; set; }
        public string PostType { get; set; }
        public string PostTypeTranslated
        {
            get { return PostType.GetLocalizedConstant(); }
        }
        public long VoucherId { get; set; }
        public int VoucherNumber { get; set; }
        public long EconomicTransactionId { get; set; }
        public long? SettlementId { get; set; }
        public long? LedgerLineId { get; set; }
        public decimal RunningTotal { get; set; }
    }
}