using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class SubscriptionSetupDto : EntityDto
    {
        public string Culture { get; set; }
        public string CultureDisplayName
        {
            get { return Culture.GetLocalizedCultureName(); }
        }

        public string Body { get; set; }
        public string Subject { get; set; }
        public string Email { get; set; }
    }
}