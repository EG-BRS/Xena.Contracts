using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class OrderContextDto : EntityDto
    {
        public string ContextType { get; set; }
        public long PartnerId { get; set; }
        public TermsOfPaymentDto TermsOfPayment { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public string CurrencyDescription => CurrencyAbbreviation.GetLocalizedCurrencyName();
        public string InvoiceEmail { get; set; }
        public long? OfferReportLayoutId { get; set; }
        public long? DeliveryReportLayoutId { get; set; }
        public long? InvoiceReportLayoutId { get; set; }
        public long? ConfirmationReportLayoutId { get; set; }
        public string OfferReportLayoutName { get; set; }
        public string DeliveryReportLayoutName { get; set; }
        public string InvoiceReportLayoutName { get; set; }
        public string ConfirmationReportLayoutName { get; set; }
        public long? PriceGroupId { get; set; }
        public string PriceGroupDescription { get; set; }
        public string ArticleGroupDescription { get; set; }
        public int? LedgerTagNumber { get; set; }
        public string LedgerTagDescription { get; set; }
        public string ContextDescription => ContextType.GetLocalizedConstant();
        public string Culture { get; set; }
        public string CultureDisplayName => Culture.GetLocalizedCultureName();
        public long? DefaultArticleGroupId { get; set; }
        public long? DefaultLedgerTagId { get; set; }
        public string DefaultLedgerAccount { get; set; }
        public long? DefaultVatId { get; set; }
        public string DefaultVatAbbreviation { get; set; }

        public string DefaultBookkeepingText => DefaultLedgerTagId.HasValue ? GetLedgerTagDescription() : DefaultArticleGroupId.HasValue ? $"{ArticleGroupDescription}{GetLedgerDescription()}" : string.Empty;

        private string GetLedgerTagDescription()
        {
            return LedgerTagNumber.HasValue ? $"{LedgerTagNumber} {LedgerTagDescription}" : LedgerTagDescription;
        }
        private string GetLedgerDescription()
        {
            return string.IsNullOrEmpty(DefaultLedgerAccount)
                ? string.Empty
                : $", {DefaultLedgerAccount.GetLocalizedConstant()}";
        }
    }
}