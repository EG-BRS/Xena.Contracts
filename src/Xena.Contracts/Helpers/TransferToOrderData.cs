namespace Xena.Contracts.Helpers
{
    public class TransferToOrderData
    {
        public long? ArticleGroupId { get; set; }
        public long? CostTypeId { get; set; }
        public long? DefaultOrderTaskId { get; set; }
        public long VoucherPreviewId { get; set; }
        public bool CreateArticles { get; set; }
        public bool TransferToCosts { get; set; }
        public bool CreatePurchaseOrder { get; set; }
    }
}