using System;

namespace Xena.Contracts.Domain
{
    public class OrderJournalEntryDto:TransactionalDto
    {
        public long OrderId { get; set; }
        public string Description { get; set; }
        public string EntryType { get; set; }
        public long? DocumentId { get; set; }
        public long? OrderInvoiceTransactionId { get; set; }
        public long? OrderDeliveryTransactionId { get; set; }
        public long TransactionId { get; set; }
        public int? VoucherNumber { get; set; }
        public long? ResponsibleId { get; set; }
        public string ResponsibleName { get; set; }

        public static class EntryTypes
        {
            public const string OrderJournal = "OrderJournalEntry";
            public const string ElectronicInvoice = "ElectronicInvoiceJournalEntry";
            public const string Payment = "PaymentJournal";
        }
    }

}