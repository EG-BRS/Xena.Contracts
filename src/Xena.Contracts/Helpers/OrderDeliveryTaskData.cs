using System.Collections.Generic;

namespace Xena.Contracts.Helpers
{
    public class OrderDeliveryTaskData
    {
        public long OrderTaskId { get; set; }
        public string OrderTaskDescription { get; set; }
        public bool CanDeliver { get; set; }
        public IList<OrderDeliveryLineData> OrderLines { get; set; }
        public int OrderNumber { get; set; }
    }
}