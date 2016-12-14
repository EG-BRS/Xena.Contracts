


namespace Xena.Contracts.Domain
{
    public class SubscriptionInvoiceDto : FiscalDto, IHasIdDto
    {
        public long? Id { get; set; }
        public long OrderId { get; set; }
        public long SubscriptionId { get; set; }
        public int OrderNumber { get; set; }
        public int? InvoiceNumber { get; set; }
        public long? OrderInvoiceTransactionId { get; set; }
        public long? OrderJournalEntryId { get; set; }
        public long? SettlementId { get; set; }
        public decimal? PriceNettTotal { get; set; }
        public int? InvoicingDateDays { get; set; }

        public string InvoicingDateDaysFriendly { get; set; }

        public string State { get; set; }
        public string StateFriendly { get; set; }
    }
}