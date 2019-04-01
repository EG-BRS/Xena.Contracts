namespace Xena.Contracts.ApiRoutes
{
    public class ActivityTypeRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/ActivityType"</summary>
        public const string Base = "Fiscal/{fiscalId}/ActivityType";

        /// <summary>"NonBillable"</summary>
        public const string GetNonBillable = "NonBillable";

        /// <summary>"LedgerLineType"</summary>
        public const string GetActivityTypeTypeList = "ActivityTypeType";
    }
}