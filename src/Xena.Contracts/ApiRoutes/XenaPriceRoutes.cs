namespace Xena.Contracts.ApiRoutes
{
    public class XenaPriceRoutes
    {
        /// <summary>"Fiscal/{fiscalId}"</summary>
        public const string Base = "Fiscal/{fiscalId}/XenaUserPrice";

        /// <summary>"GetUserPriceInfo"</summary>
        public const string GetUserPriceInfo = "GetUserPriceInfo";

        /// <summary>"{article}"</summary>
        public const string GetXenaUserPrice = "{article}";

        /// <summary>"~/Fiscal/{fiscalId}/Membership/{membershipId}/DeletionConsequence"</summary>
        public const string GetSubscriptionConsequenceForDeletion = "~/Fiscal/{fiscalId}/Membership/{membershipId}/DeletionConsequence";
    }
}