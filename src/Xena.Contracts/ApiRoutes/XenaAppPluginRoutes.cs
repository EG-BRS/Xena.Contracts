namespace Xena.Contracts.ApiRoutes
{
    public class XenaAppPluginRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/XenaAppPlugin"</summary>
        public const string Base = "Fiscal/{fiscalId}/XenaAppPlugin";

        /// <summary>"~/Fiscal/{fiscalId}/XenaApp/{id}/Plugin"</summary>
        public const string GetByXenaAppList = "~/Fiscal/{fiscalId}/XenaApp/{id}/Plugin";

        /// <summary>"PluginType"</summary>
        public const string GetPluginTypeList = "PluginType";

        /// <summary>"~/Fiscal/{fiscalId}/XenaApp/{id}/ParentPlugins"</summary>
        public const string GetParentPlugins = "~/Fiscal/{fiscalId}/XenaApp/{id}/ParentPlugins";
    }
}