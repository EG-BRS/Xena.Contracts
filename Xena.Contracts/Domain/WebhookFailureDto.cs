namespace Xena.Contracts.Domain
{
    public class WebhookFailureDto : FiscalDto, IHasIdDto
    {
        public long? Id { get; set; }
        public long WebHookSubscriptionId { get; set; }
        public string Fault { get; set; }
    }
}