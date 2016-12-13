namespace Xena.Contracts.Domain
{
    public class WebHookSubscriptionDto : EntityDto
    {
        public string CallBackUrl { get; set; }
        public long? EntityId { get; set; }
        public string EntityType { get; set; }
        public int WindowFailureCount { get; set; }
    }
}