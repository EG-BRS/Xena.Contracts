

namespace Xena.Contracts.Domain
{
    public class OrderDeliveryDto
    {
        public long OrderId { get; set; }
        public int DeliveryDateDays { get; set; }
        public bool IsCancelled { get; set; }
        public string DeliveryDateDaysFriendly
        { get; set; }
    }
}