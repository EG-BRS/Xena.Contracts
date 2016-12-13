namespace Xena.Contracts.Helpers
{
    public class OrderDeliverData
    {
        public int Version { get; set; }
        public int? DeliveryDate { get; set; }
        public long? DeliveryReportLayoutId { get; set; }
        public long[] OrderTaskIds { get; set; }
        public long? TemporaryLocationId { get; set; }
    }
}