using System.ComponentModel;
using Xena.Contracts.Domain;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Helpers
{
    public class XenaAppPluginDto : EntityDto
    {
        public string Title { get; set; }
        public string IconCssClass { get; set; }
        public int? Index { get; set; }
        public string PluginPlacement { get; set; }
        public string PluginType { get; set; }
        public string ExternalUri { get; set; }
        public long XenaAppId { get; set; }
        public long? ParentPluginId { get; set; }

        //Convinience properties
        private string _pluginPlacementTranslated = null;
        [ReadOnly(true)]
        public string PluginPlacementTranslated
        {
            get
            {
                return _pluginPlacementTranslated ?? (string.IsNullOrEmpty(PluginPlacement)
                           ? string.Empty
                           : PluginPlacement.GetLocalizedConstant());
            }
            set { _pluginPlacementTranslated = value; }
        }
        private string _pluginTypeTranslated = null;
        [ReadOnly(true)]
        public string PluginTypeTranslated
        {
            get
            {
                return _pluginTypeTranslated ??
                       (string.IsNullOrEmpty(PluginType) ? string.Empty : PluginType.GetLocalizedConstant());
            }
            set { _pluginTypeTranslated = value; }
        }
    }
}