

namespace Xena.Contracts.Domain
{
    public class PartnerContextTemplateDto:EntityDto
    {
        public TermsOfPaymentDto TermsOfPayment { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public string ContextType { get; set; }
        public string Culture { get; set; }
        public long? DeliveryReportLayoutId { get; set; }
        public long? OfferReportLayoutId { get; set; }
        public long? InvoiceReportLayoutId { get; set; }
        public long? ConfirmationReportLayoutId { get; set; }
        public string OfferReportLayoutName { get; set; }
        public string DeliveryReportLayoutName { get; set; }
        public string InvoiceReportLayoutName { get; set; }
        public string ConfirmationReportLayoutName { get; set; }
        public string CurrencyDescription { get; set; }
        public string ContextDescription { get; set; }
        public string CultureDisplayName { get; set; }
    }
}