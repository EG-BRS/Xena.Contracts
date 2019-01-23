using System.Collections.Generic;

namespace Xena.Contracts.Helpers
{
    public class DiscountCodeData
    {
        public int? QuantityRequested { get; set; }
        public int ExpirationDate { get; set; }
        public string Description { get; set; }
        public IEnumerable<long?> Apps { get; set; }
    }

}