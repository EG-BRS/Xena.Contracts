using Xena.Contracts.Domain;

namespace Xena.Contracts.Helpers
{
    public class XenaAppBundleItemDto : EntityDto
    {
        public long XenaAppBundleId { get; set; }
        public long? XenaAppId { get; set; }
        public string XenaAppName { get; set; }
        public string XenaAppDescription { get; set; }
        public long? XenaAppIconId { get; set; }
    }
}