namespace Xena.Contracts.Helpers
{
    public class WebHookEventData
    {
        public string EntityType { get; set; }
        public long EntityId { get; set; }
        public string EntityEvent { get; set; }

        public static class WebHookEvents
        {
            public const string Created = "Created";
            public const string Updated = "Updated";
            public const string Deleted = "Deleted";
            public const string ArticleStockUpdated = "ArticleStockUpdated";
            public const string OrderSummaryUpdated = "OrderSummaryUpdated";
        }
    }
}