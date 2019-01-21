using System.ComponentModel;

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
        public long ResourceInboxDocumentRelationId { get; set; }
        public string Description { get; set; }
        public bool SaveBookkeepingSetup { get; set; }
        public decimal? ExchangeRate { get; set; }
        public string PartnerSuggestionCVR { get; set; }
        public string PartnerSuggestionName { get; set; }
        public string PaymentIdentification { get; set; }
        public long? OrderTaskLedgerId { get; set; }
        public string OrderTaskLedgerDescription { get; set; }

        //Convinience properties
        [ReadOnly(true)]
        public bool IsBookkeeping { get; set; }
        [ReadOnly(true)]
        public bool IsBookkept { get; set; }
        [ReadOnly(true)]
        public bool IsAuthorized { get; set; }
        [ReadOnly(true)]
        public bool IsTaskPreviewsLocked { get; set; }
        [ReadOnly(true)]
        public long? AuthorizedById { get; set; }
        [ReadOnly(true)]
        public int? PartnerAccountNumber { get; set; }
        [ReadOnly(true)]
        public string PartnerName { get; set; }
    }
}