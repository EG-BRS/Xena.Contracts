using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class OrderTaskJournalEntryDto : TransactionalDto
    {
        private string _description;
        public string Description
        {
            get { return string.IsNullOrEmpty(_description)? UI.Dto_OrderTaskJournalEntry_DefaultDescription:_description; }
            set { _description = value; }
        }

        public long OrderTaskId { get; set; }
        public long JournalId { get; set; }
        public bool HasDocument { get; set; }
        public int? VoucherNumber { get; set; }
        public int? FiscalDateDays { get; set; }
        public string FiscalDateDaysFriendly
        {
            get { return FiscalDateDays.HasValue ? FiscalDateDays.Value.FriendlyString() : null; }
        }
        public long? OrderInvoiceTransactionId { get; set; }
        public long? OrderDeliveryTransactionId { get; set; }
        public long? EconomicTransactionId { get; set; }

        public string JournalType { get; set; }
    }
}