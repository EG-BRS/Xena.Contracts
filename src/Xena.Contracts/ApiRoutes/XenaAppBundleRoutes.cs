namespace Xena.Contracts.ApiRoutes
{
    public class XenaAppBundleRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/XenaAppBundle"</summary>
        public const string Base = "Fiscal/{fiscalId}/XenaAppBundle";

        /// <summary>"{id}/RequestApproval"</summary>
        public const string PutRequestApproval = "{id}/RequestApproval";

        /// <summary>"{id}/RequestUnapproval"</summary>
        public const string PutRequestUnapproval = "{id}/RequestUnapproval";

        /// <summary>"{id}/TakeDown"</summary>
        public const string DeleteTakeDown = "{id}/TakeDown";

        /// <summary>"{id}/RequestApproval"</summary>
        public const string DeleteRequestApproval = "{id}/RequestApproval";
    }
}