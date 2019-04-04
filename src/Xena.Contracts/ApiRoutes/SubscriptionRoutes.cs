namespace Xena.Contracts.ApiRoutes
{
    public class SubscriptionRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/Subscription"</summary>
        public const string Base = "Fiscal/{fiscalId}/Subscription";

        /// <summary>"Fiscal/{fiscalId}/Subscription"</summary>
        public const string BaseXenaFiscalSubscriptionLine = Base + "/XenaFiscalSubscriptionLine";

        /// <summary>"~/Fiscal/{fiscalId}/Partner/{id}/Subscription"</summary>
        public const string GetByPartner = "~/Fiscal/{fiscalId}/Partner/{id}/Subscription";

        /// <summary>"~/Fiscal/{fiscalId}/Article/{id}/Subscription"</summary>
        public const string GetByArticle = "~/Fiscal/{fiscalId}/Article/{id}/Subscription";

        /// <summary>"History"</summary>
        public const string GetHistory = "History";

        /// <summary>"Active"</summary>
        public const string GetActive = "Active";

        /// <summary>"Inactive"</summary>
        public const string GetInactive = "Inactive";

        /// <summary>"{id}/Activate"</summary>
        public const string PutActivate = "{id}/Activate";

        /// <summary>"{id}/Deactivate"</summary>
        public const string PutDeactivate = "{id}/Deactivate";

        /// <summary>"{id}/Invoice"</summary>
        public const string GetInvoice = "{id}/Invoice";

        /// <summary>"~/Partner/{id}/Subscription"</summary>
        public const string PostFromPartner = "~/Fiscal/{fiscalId}/Partner/{id}/Subscription";

        /// <summary>"{id}/XenaUserSubscriptionLine"</summary>
        public const string GetXenaUserSubscriptionLineList = "{id}/XenaUserSubscriptionLine";

        /// <summary>"{id}/XenaFiscalSubscriptionLine"</summary>
        public const string GetXenaFiscalSubscriptionLineList = "{id}/XenaFiscalSubscriptionLine";

        /// <summary>"XenaFiscalSubscriptionLine/{id}"</summary>
        public const string GetXenaFiscalSubscriptionLine = "XenaFiscalSubscriptionLine/{id}";
    }
}