using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class OnlinePartnerPaymentDto : TransactionalDto
    {
        public long EconomicTransactionId { get; set; }
        public string PaymentMethod { get; set; }
        public int PaymentDateDays { get; set; }
        public int VoucherNumber { get; set; }
        public int PartnerAccountNumber { get; set; }
        public long PartnerId { get; set; }
        public string PartnerName { get; set; }
        private string _paymentDateDaysFriendly = null;
        [ReadOnly(true)]
        public string PaymentDateDaysFriendly
        {
            get { return _paymentDateDaysFriendly ?? PaymentDateDays.FriendlyString(); }
            set { _paymentDateDaysFriendly = value; }
        }
    }
}