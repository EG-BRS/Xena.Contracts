namespace Xena.Contracts.Domain
{
    public class HelpLinkDto : EntityDto
    {
        public long HelpId { get; set; }
        public string Culture { get; set; }
        public string Uri { get; set; }
        public string UriInline { get; set; }
    }
}