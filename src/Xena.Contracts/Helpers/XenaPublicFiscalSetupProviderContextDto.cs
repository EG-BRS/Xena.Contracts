using Xena.Contracts.Domain;

namespace Xena.Contracts.Helpers
{
    public class XenaPublicProviderContextDto : IHasIdDto
    {
        public long? Id { get; set; }
        public long ProviderId { get; set; }
        public string DefaultTheme { get; set; }
    }
}