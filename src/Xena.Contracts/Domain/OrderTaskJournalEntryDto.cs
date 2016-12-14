

namespace Xena.Contracts.Domain
{
    public class OrderTaskJournalEntryDto : TransactionalDto
    {
        private string _description;
        public string Description { get; set; }

        public long OrderTaskId { get; set; }
        public long JournalId { get; set; }
        public bool HasDocument { get; set; }
        public int? VoucherNumber { get; set; }
        public int? FiscalDateDays { get; set; }
        public string FiscalDateDaysFriendly
        { get; set; }
        public long? OrderInvoiceTransactionId { get; set; }
        public long? OrderDeliveryTransactionId { get; set; }
        public long? EconomicTransactionId { get; set; }

        public string JournalType { get; set; }
    }
}