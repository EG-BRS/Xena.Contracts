namespace Xena.Contracts.Domain
{
    public class XenaProviderReleaseNotesLinkDto : IHasIdDto
    {
        public long? Id { get; protected set; }
        public long ProviderId { get; protected set; }
        public string Culture { get; set; }
        public string Uri { get; set; }
    }
}