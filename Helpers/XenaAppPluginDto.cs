using Xena.Contracts.Domain;
using Xena.Resources;

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
        {
            get { return string.IsNullOrEmpty(PluginPlacement) ? string.Empty : PluginPlacement.GetLocalizedConstant(); }
        }
        public string PluginTypeTranslated
        {
            get { return string.IsNullOrEmpty(PluginType) ? string.Empty : PluginType.GetLocalizedConstant(); }
        }
    }
}