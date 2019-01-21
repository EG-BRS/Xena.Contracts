using System.ComponentModel;

namespace Xena.Contracts.Domain
{
    public class XenaHelpLinkDto : IHasIdDto
    {
        [ReadOnly(true)]
        public long? Id { get; set; }
        [ReadOnly(true)]
        public long ProviderId { get; set; }
        public long HelpId { get; set; }
        public string Culture { get; set; }
        public string Uri { get; set; }
        public string UriInline { get; set; }
    }
}