using System.Collections.Generic;

namespace Xena.Contracts.Helpers
{
    public class SplitOrderData
    {
        public IList<SplitOrderLineData> OrderLines { get; set; }
        public string ContextType { get; set; }
    }
}