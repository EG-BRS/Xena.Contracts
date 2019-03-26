namespace Xena.Contracts.ApiRoutes
{
    public class XenaAppRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/XenaApp"</summary>
        public const string Base = "Fiscal/{fiscalId}/XenaApp";

        /// <summary>"Visibility"</summary>
        public const string GetVisibilityList = "Visibility";

        /// <summary>"Category"</summary>
        public const string GetCategoryList = "Category";

        /// <summary>"{id}/RequestApproval"</summary>
        public const string PutRequestApproval = "{id}/RequestApproval";

        /// <summary>"{id}/RequestUnapproval"</summary>
        public const string PutRequestUnapproval = "{id}/RequestUnapproval";

        /// <summary>"{id}/TakeDown"</summary>
        public const string DeleteTakeDown = "{id}/TakeDown";

        /// <summary>"{id}/RequestApproval"</summary>
        public const string DeleteRequestApproval = "{id}/RequestApproval";

        /// <summary>"{xenaAppId}/SubscriberFiscal"</summary>
        public const string GetSubscriberFiscalList = "{xenaAppId}/SubscriberFiscal";

        /// <summary>"SubscriberUser/{id}"</summary>
        public const string GetSubscriberUser = "SubscriberUser/{id}";

        /// <summary>"{xenaAppId}/SubscriberUser"</summary>
        public const string GetSubscriberUserList = "{xenaAppId}/SubscriberUser";
    }
}