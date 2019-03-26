namespace Xena.Contracts.ApiRoutes
{
    public class XenaAppAdminRoutes
    {
        /// <summary>"WorkScheduleRoutesXenaApp"</summary>
        public const string Base = "WorkScheduleRoutesFiscal/{fiscalId}/XenaAppAdmin";

        /// <summary>"{id}"</summary>
        public const string Get = "{id}";

        /// <summary>""</summary>
        public const string GetList = "";

        /// <summary>"AwaitingApproval"</summary>
        public const string GetAwaitingApprovalList = "AwaitingApproval";

        /// <summary>"{id}/Approve"</summary>
        public const string Approve = "{id}/Approve";

        /// <summary>"{id}/TakeDown"</summary>
        public const string TakeDown = "{id}/TakeDown";

        /// <summary>"{id}/UpdatePrice"</summary>
        public const string UpdatePrice = "{id}/UpdatePrice";

        /// <summary>"~/WorkScheduleRoutesFiscal/{fiscalId}/App/{id}/Price"</summary>
        public const string GetPricesByApp = "~/WorkScheduleRoutesFiscal/{fiscalId}/App/{id}/Price";

        /// <summary>"~/WorkScheduleRoutesFiscal/{fiscalId}/App/{id}/Plugin"</summary>
        public const string GetPluginsByAppList = "~/WorkScheduleRoutesFiscal/{fiscalId}/App/{id}/Plugin";

        /// <summary>"~/WorkScheduleRoutesFiscal/{fiscalId}/App/{id}/BundleItem"</summary>
        public const string GetBundleItemsByAppList = "~/WorkScheduleRoutesFiscal/{fiscalId}/App/{id}/BundleItem";
    }
}