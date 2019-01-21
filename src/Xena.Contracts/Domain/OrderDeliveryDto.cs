using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class OrderDeliveryDto
    {
        public long OrderId { get; set; }
        public int DeliveryDateDays { get; set; }
        public bool IsCancelled { get; set; }
        private string _deliveryDateDaysFriendly = null;
        [ReadOnly(true)]
        public string DeliveryDateDaysFriendly
        {
            get { return _deliveryDateDaysFriendly ?? DeliveryDateDays.FriendlyString(); }
            set { _deliveryDateDaysFriendly = value; }
        }
    }
}