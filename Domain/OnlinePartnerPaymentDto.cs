using Xena.Resources;

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
        public string PaymentDateDaysFriendly
        {
            get { return PaymentDateDays.FriendlyString(); }
        }
    }
}