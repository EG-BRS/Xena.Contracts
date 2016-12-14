

namespace Xena.Contracts.Domain
{
    public class SubscriptionSetupDto : EntityDto
    {
        public string Culture { get; set; }
        public string CultureDisplayName
        { get; set; }

        public string Body { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }
    }
}