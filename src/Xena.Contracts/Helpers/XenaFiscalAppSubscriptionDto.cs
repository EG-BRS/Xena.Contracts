using Xena.Contracts.Domain;

namespace Xena.Contracts.Helpers
{
    public class XenaFiscalAppSubscriptionDto : XenaFiscalDto
    {
        public long XenaAppId { get; set; }
        public long PartnerResourceContextId { get; set; }
        public string ResourceName { get; set; }
        public int? ExpiresOnDays { get; set; }
    }
}