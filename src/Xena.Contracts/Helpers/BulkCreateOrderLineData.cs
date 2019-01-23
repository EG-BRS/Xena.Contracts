using System.Collections.Generic;
using Xena.Contracts.Domain;

namespace Xena.Contracts.Helpers
{
    public class BulkCreateOrderLineData
    {
        public long OrderTaskId { get; set; }
        public IEnumerable<OrderLineDto> Lines { get; set; }
    }
}
