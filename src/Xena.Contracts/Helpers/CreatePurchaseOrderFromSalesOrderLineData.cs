namespace Xena.Contracts.Helpers
{
    public class CreatePurchaseOrderFromSalesOrderLineData
    {
        public long OrderLineId { get; set; }
        public long SupplierId { get; set; }
        public decimal Quantity { get; set; }
        public decimal? PriceEach { get; set; }
        public long? PurchaseOrderId { get; set; }
        public long? ArticleVariantId { get; set; }
    }
}