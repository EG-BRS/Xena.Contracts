namespace Xena.Contracts.Search
{
    public class OrderTaskSearchIndex
    {
        public long Id { get; set; }
        public string OrderNumber { get; set; }
        public string OrderNumberSplits { get; set; }
        public string OrderTaskNumber { get; set; }
        public string OrderTaskNumberSplits { get; set; }
        public string ProjectNumber { get; set; }
        public string ProjectNumberSplits { get; set; }
        public string Details { get; set; }
        public string Description { get; set; }
        public string ProjectDetails { get; set; }
        public string ProjectDescription { get; set; }
        public string OrderInternalNote { get; set; }
        public string PartnerAccountNumber { get; set; }
        public string OrderName { get; set; }
        public string OrderPlaceName { get; set; }
        public string OrderStreet { get; set; }
        public string OrderZip { get; set; }
        public string OrderCity { get; set; }
        public string OrderCountryName { get; set; }
        public string OrderAttention { get; set; }
        public string DeliveryName { get; set; }
        public string DeliveryPlaceName { get; set; }
        public string DeliveryStreet { get; set; }
        public string DeliveryZip { get; set; }
        public string DeliveryCity { get; set; }
        public string DeliveryCountryName { get; set; }
        public string DeliveryAttention { get; set; }
        public string ContextType { get; set; }
        public long FiscalSetupId { get; set; }
        public bool IsDeactivated { get; set; }
        public bool IsDelivered { get; set; }
        public bool IsInvoiced { get; set; }
        public long OrderId { get; set; }
        public int CreatedDate { get; set; }
    }
}