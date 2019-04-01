namespace Xena.Contracts.ApiRoutes
{
    public class SubscriptionLineRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/SubscriptionLine"</summary>
        public const string Base = "Fiscal/{fiscalId}/SubscriptionLine";

        /// <summary>"~/Fiscal/{fiscalId}/Subscription/{id}/SubscriptionLine"</summary>
        public const string GetBySubscription = "~/Fiscal/{fiscalId}/Subscription/{id}/SubscriptionLine";

        /// <summary>"{id}/Protect"</summary>
        public const string PutProtect = "{id}/Protect";

        /// <summary>"{id}/Unprotect"</summary>
        public const string PutUnprotect = "{id}/Unprotect";

        /// <summary>"Payer"</summary>
        public const string PutPayer = "Payer";

        /// <summary>"IntervalType"</summary>
        public const string GetIntervalType = "IntervalType";


    }
}