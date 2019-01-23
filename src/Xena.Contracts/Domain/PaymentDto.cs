using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class PaymentDto : TransactionalDto
    {
        //PartnerPost
        [ReadOnly(true)]
        public string SupplierInvoiceNumber { get; set; }
        [ReadOnly(true)]
        public decimal Amount { get; set; }
        [ReadOnly(true)]
        public string CurrencyAbbreviation { get; set; }
        [ReadOnly(true)]
        public decimal CurrencyAmount { get; set; }
        [ReadOnly(true)]
        public int DueDateDays { get; set; }
        [ReadOnly(true)]
        public int FiscalDateDays { get; set; }
        [ReadOnly(true)]
        public long PartnerId { get; set; }
        [ReadOnly(true)]
        public int PartnerAccountNumber { get; set; }
        [ReadOnly(true)]
        public string PartnerName { get; set; }
        [ReadOnly(true)]
        public string PostType { get; set; }
        [ReadOnly(true)]
        public long VoucherId { get; set; }
        [ReadOnly(true)]
        public int VoucherNumber { get; set; }
        [ReadOnly(true)]
        public long EconomicTransactionId { get; set; }
        [ReadOnly(true)]
        public long? PaymentExportedId { get; set; }
        [ReadOnly(true)]
        public long? SettlementId { get; set; }
        [ReadOnly(true)]
        public string PaymentIdentification { get; set; }

        //SupplierContext
        [ReadOnly(true)]
        public long? PartnerSupplierContextId { get; set; }
        [ReadOnly(true)]
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
        [ReadOnly(true)]
        public string Account { get; set; }
        [ReadOnly(true)]
        public string AccountIdentifier { get; set; }
        [ReadOnly(true)]
        public bool? GroupPayments { get; set; }
        //calculated properties
        public bool IsPosssible { get; set; }
        public string[] Errors { get; set; }

        //Convinience properties
        private string _dueDateDaysFriendly = null;
        [ReadOnly(true)]
        public string DueDateDaysFriendly
        {
            get { return _dueDateDaysFriendly ?? DueDateDays.FriendlyString(); }
            set { _dueDateDaysFriendly = value; }
        }

        private string _fiscalDateDaysFriendly = null;
        [ReadOnly(true)]
        public string FiscalDateDaysFriendly
        {
            get { return _fiscalDateDaysFriendly ?? FiscalDateDays.FriendlyString(); }
            set { _fiscalDateDaysFriendly = value; }
        }

        private string _postTypeTranslated = null;
        [ReadOnly(true)]
        public string PostTypeTranslated
        {
            get { return _postTypeTranslated ?? PostType.GetLocalizedConstant(); }
            set { _postTypeTranslated = value; }
        }
    }
}