namespace Xena.Contracts.Helpers
{
    public class SubscribeAppData
    {
        public long[] MembershipIds { get; set; }
    }

    public class UnsubscribeAppData
    {
        public long XenaSubscriberId { get; set; }
    }
}