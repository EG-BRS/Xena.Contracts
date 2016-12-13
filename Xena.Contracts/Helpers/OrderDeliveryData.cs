using System.Collections.Generic;

namespace Xena.Contracts.Helpers
{
    public class OrderDeliveryData
    {
        public IList<OrderDeliveryTaskData> OrderTasks { get; set; } 
    }
}