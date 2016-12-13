namespace Xena.Contracts.Helpers
{
    public class PurchaseDraftCreateData
    {
        public long? SupplierId { get; set; }
        public long ArticleId { get; set; }
        public long? ArticleVariantId { get; set; }
        public decimal Quantity { get; set; }
    }
}