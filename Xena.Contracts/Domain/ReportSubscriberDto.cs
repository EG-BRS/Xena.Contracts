using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class ReportSubscriberDto:IHasIdDto
    {
        public long ReportSubscriptionId { get; set; }
        public string Culture { get; set; }
        public string Email { get; set; }
        public string CultureDisplayName
        {
            get { return string.IsNullOrEmpty(Culture) ? string.Empty: Culture.GetLocalizedCultureName(); }
        }

        public long? Id { get; set; }
    }
}