namespace Xena.Contracts.Helpers
{
    public class PartnerArticleStatisticsData
    {
        public long Id { get; set; }
        public string ArticleNumber { get; set; }
        public string ArticleDescription { get; set; }
        public long? ArticleGroupId { get; set; }
        public string ArticleGroupDescription { get; set; }
        public decimal SalesQuantity { get; set; }
        public decimal SalesAmount { get; set; }
        public decimal PurchasingQuantity { get; set; }
        public decimal PurchasingAmount { get; set; }
    }
}