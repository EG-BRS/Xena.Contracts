using Xena.Contracts.Domain;
using Xena.Resources;

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
        public string ContextTypeTranslated => ContextType.GetLocalizedConstant();
        public bool IsSettled => SettlementId.HasValue;
        public string UserName => Journal == null ? string.Empty : Journal.CreatedByName;
        public long? DocumentId => Journal?.DocumentId;
        public string PartnerPostTypeTranslated => string.IsNullOrEmpty(PartnerPostType)?string.Empty: PartnerPostType.GetLocalizedConstant();
    }
}