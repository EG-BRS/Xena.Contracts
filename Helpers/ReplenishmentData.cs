using System.Collections.Generic;

namespace Xena.Contracts.Helpers
{
    public class ReplenishmentData
    {
        public IEnumerable<PurchaseDraftCreateData> Replenishments { get; set; }
    }
}