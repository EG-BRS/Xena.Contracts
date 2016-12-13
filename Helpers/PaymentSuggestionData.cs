using System.Collections.Generic;

namespace Xena.Contracts.Helpers
{
    public class PaymentSuggestionData
    {
        public long? PartnerId { get; set; }
        public string PartnerName { get; set; }
        public IList<long> SettledPartnerPostIds { get; set; }
        public string VoucherNumbers { get; set; }
        public int? PartnerAccountNumber { get; set; }
        public decimal? Amount { get; set; }
        public bool ManualPayment { get; set; }
    }
}