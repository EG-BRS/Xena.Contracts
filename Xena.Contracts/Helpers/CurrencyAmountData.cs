using System.Collections.Generic;

namespace Xena.Contracts.Helpers
{
    public class CurrencyAmountData
    {
        public decimal? AmountToPay { get; set; }
        public decimal AllowedDifference { get; set; }
        public IList<CurrencyAmountDetailsData> Details { get; set; }
        public IEnumerable<string> Messages { get; set; }
        public bool CanPay { get; set; }
    }

    public class CurrencyAmountDetailsData
    {
        public long PartnerPostId { get; set; }
        public decimal AmountToPay { get; set; }
    }
}