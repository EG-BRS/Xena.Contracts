using System.ComponentModel;
using Xena.Contracts.Domain;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Helpers
{
    public class XenaFiscalAppPluginDto : XenaFiscalDto
    {
        [ReadOnly(true)]
        public string Title { get; set; }
        [ReadOnly(true)]
        public string IconCssClass { get; set; }
        [ReadOnly(true)]
        public int? Index { get; set; }
        [ReadOnly(true)]
        public string PluginPlacement { get; set; }
        [ReadOnly(true)]
        public string PluginType { get; set; }
        public string ExternalUri { get; set; }
        [ReadOnly(true)]
        public long XenaAppId { get; set; }
        [ReadOnly(true)]
        public long? ParentPluginId { get; set; }
        [ReadOnly(true)]
        public long PartnerResourceContextId { get; set; }
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