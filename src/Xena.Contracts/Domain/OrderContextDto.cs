using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class OrderContextDto : EntityDto
    {
        public string ContextType { get; set; }
        public long PartnerId { get; set; }
        public TermsOfPaymentDto TermsOfPayment { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public string InvoiceEmail { get; set; }
        public long? OfferReportLayoutId { get; set; }
        public long? DeliveryReportLayoutId { get; set; }
        public long? InvoiceReportLayoutId { get; set; }
        public long? ConfirmationReportLayoutId { get; set; }
        public long? PriceGroupId { get; set; }
        public string Culture { get; set; }
        public long? DefaultArticleGroupId { get; set; }
        public long? DefaultLedgerTagId { get; set; }
        public long? DefaultVatId { get; set; }
        public string DefaultLedgerAccount { get; set; }
        public string PaymentMeansType { get; set; }
        private string _paymentMeansTypeTranslated = null;
        [ReadOnly(true)]
        public string PaymentMeansTypeTranslated
        {
            get
            {
                return _paymentMeansTypeTranslated ?? (string.IsNullOrEmpty(PaymentMeansType)
                           ? string.Empty
                           : PaymentMeansType.GetLocalizedConstant());
            }
            set { _paymentMeansTypeTranslated = value; }
        }
        public string Account { get; set; }
        public string AccountIdentifier { get; set; }
        private string _accountLabelTranslated = null;
        [ReadOnly(true)]
        public string AccountLabelTranslated
        {
            get
            {
                return _accountLabelTranslated ?? (string.IsNullOrEmpty(PaymentMeansType)
                           ? string.Empty
                           : $"{PaymentMeansType}_AccountLabel".GetLocalizedConstant());
            }
            set { _accountLabelTranslated = value; }
        }
        private string _accountIdentifierLabelTranslated = null;
        [ReadOnly(true)]
        public string AccountIdentifierLabelTranslated
        {
            get
            {
                return _accountIdentifierLabelTranslated ?? (string.IsNullOrEmpty(PaymentMeansType)
                           ? string.Empty
                           : $"{PaymentMeansType}_AccountIdentifierLabel".GetLocalizedConstant());
            }
            set { _accountIdentifierLabelTranslated = value; }
        }

        public bool GroupPayments { get; set; }
        public string DefaultPaymentMessage { get; set; }
        //Convinience properties
        [ReadOnly(true)]
        public string PartnerName { get; set; }
        [ReadOnly(true)]
        public string DefaultVatAbbreviation { get; set; }
        [ReadOnly(true)]
        public string PriceGroupDescription { get; set; }
        [ReadOnly(true)]
        public string ArticleGroupDescription { get; set; }
        [ReadOnly(true)]
        public int? LedgerTagNumber { get; set; }
        [ReadOnly(true)]
        public string LedgerTagDescription { get; set; }
        [ReadOnly(true)]
        public string OfferReportLayoutName { get; set; }
        [ReadOnly(true)]
        public string DeliveryReportLayoutName { get; set; }
        [ReadOnly(true)]
        public string InvoiceReportLayoutName { get; set; }
        [ReadOnly(true)]
        public string ConfirmationReportLayoutName { get; set; }
        private string _currencyDescription = null;
        [ReadOnly(true)]
        public string CurrencyDescription
        {
            get { return _currencyDescription ?? CurrencyAbbreviation.GetLocalizedCurrencyName(); }
            set { _currencyDescription = value; }
        }

        private string _contextDescription = null;
        [ReadOnly(true)]
        public string ContextDescription
        {
            get { return _contextDescription ?? ContextType.GetLocalizedConstant(); }
            set { _contextDescription = value; }
        }

        private string _cultureDisplayName = null;
        [ReadOnly(true)]
        public string CultureDisplayName
        {
            get { return _cultureDisplayName ?? Culture.GetLocalizedCultureName(); }
            set { _cultureDisplayName = value; }
        }
        private string _defaultBookkeepingText = null;
        [ReadOnly(true)]
        public string DefaultBookkeepingText
        {
            get
            {
                return _defaultBookkeepingText ?? (DefaultLedgerTagId.HasValue ? GetLedgerTagDescription() :
                           DefaultArticleGroupId.HasValue ? $"{ArticleGroupDescription}{GetLedgerDescription()}" :
                           string.Empty);
            }
            set { _defaultBookkeepingText = value; }
        }
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