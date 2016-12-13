namespace Xena.Contracts.Domain
{
    public class VoucherPreviewDto : EntityDto
    {
        public string SupplierInvoiceNumber { get; set; }
        public int FiscalDateDays { get; set; }
        public int? PayDateDays { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public bool IsHandled { get; set; }
        public long? PartnerId { get; set; }
        public int? PartnerAccountNumber { get; set; }
        public string PartnerName { get; set; }
        public long ResourceInboxDocumentRelationId { get; set; }
        public string Description { get; set; }
        public bool SaveBookkeepingSetup { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string PartnerSuggestionCVR { get; set; }
        public string PartnerSuggestionName { get; set; }
    }
}