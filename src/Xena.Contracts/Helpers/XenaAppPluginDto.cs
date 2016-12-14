using Xena.Contracts.Domain;


namespace Xena.Contracts.Helpers
{
    public class XenaAppPluginDto : EntityDto
    {
        public string Title { get; set; }
        public string PluginPlacement { get; set; }
        public string PluginType { get; set; }
        public string ExternalUri { get; set; }
        public long XenaAppId { get; set; }
        public string PluginPlacementTranslated
        { get; set; }
        public string PluginTypeTranslated
        { get; set; }
    }
}