using System.ComponentModel;

namespace Xena.Contracts.Domain
{
    public class ElectronicInvoiceJournalEntryEventDto : FiscalDto, IHasIdDto
    {
        [ReadOnly(true)]
        public long? Id { get; set; }
        [ReadOnly(true)]
        public string Description { get; set; }
        [ReadOnly(true)]
        public string Details { get; set; }
        [ReadOnly(true)]
        public long DocumentId { get; set; }
        [ReadOnly(true)]
        public long ElectronicInvoiceJournalEntryId { get; set; }
    }
}