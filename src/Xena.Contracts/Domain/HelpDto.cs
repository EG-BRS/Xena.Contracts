namespace Xena.Contracts.Domain
{
    public class HelpDto: IHasIdDto
    {
        public long? Id { get; set; }
        public string Description { get; set; }
        public string Uri { get; set; }
        public string UriInline { get; set; }
    }
}