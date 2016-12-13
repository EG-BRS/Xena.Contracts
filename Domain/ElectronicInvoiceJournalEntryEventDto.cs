namespace Xena.Contracts.Domain
{
    public class ElectronicInvoiceJournalEntryEventDto : FiscalDto, IHasIdDto
    {
        public long? Id { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public long DocumentId { get; set; }
        public long ElectronicInvoiceJournalEntryId { get; set; }
    }
}