using System.ComponentModel;
using Xena.Common.ExtensionMethods;

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
            get
            {
                return _contextDescription ??
                       (string.IsNullOrEmpty(ContextType) ? string.Empty : ContextType.GetLocalizedConstant());
            }
            set { _contextDescription = value; }
        }
        private string _cultureDisplayName = null;
        [ReadOnly(true)]
        public string CultureDisplayName
        {
            get { return _cultureDisplayName ?? Culture.GetLocalizedCultureName(); }
            set { _cultureDisplayName = value; }
        }
    }
}