using System.Collections.Generic;

namespace Xena.Contracts.Helpers
{
    public class SchedulingDateData
    {
        public int Date { get; set; }
        public IList<SchedulingResourceData> Resources { get; set; }
    }
}