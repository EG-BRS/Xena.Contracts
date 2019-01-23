namespace Xena.Contracts.Helpers
{
    public class TransferPostToLineDetailData
    {
        public long[] OrderTaskPostIds { get; set; }
        public long? ArticleId { get; set; }
        public long? ArticleGroupId { get; set; }
        public long? UnitId { get; set; }
        public decimal Quantity { get; set; }
    }
}