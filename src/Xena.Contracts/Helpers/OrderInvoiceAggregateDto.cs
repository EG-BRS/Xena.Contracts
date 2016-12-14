using Xena.Contracts.Domain;


namespace Xena.Contracts.Helpers
{
    public class OrderInvoiceAggregateDto:IHasIdDto
    {
        public long? Id { get; set; }
        public string ContextType { get; set; }
        public string PartnerPostType { get; set; }
        public TotalsDto Totals { get; set; }
        public int VoucherNumber { get; set; }
        public int FiscalDateDays { get; set; }
        public long? ResourceId { get; set; }

        public long? OrderId { get; set; }
        public long? PartnerId { get; set; }
        public string PartnerName { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public int PartnerAccountNumber { get; set; }
        public OrderJournalEntryDto Journal { get; set; }
        public string SupplierInvoiceNumber { get; set; }

        public long? SettlementId { get; set; }
        public bool IsFullyDelivered { get; set; }
        public long FiscalSetupId { get; set; }
        public string ContextTypeTranslated { get; set; }
        public bool IsSettled { get; set; }
        public string UserName { get; set; }
        public long? DocumentId { get; set; }
        public string PartnerPostTypeTranslated { get; set; }
    }
}