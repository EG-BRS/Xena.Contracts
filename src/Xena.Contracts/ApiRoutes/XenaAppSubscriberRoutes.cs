namespace Xena.Contracts.ApiRoutes
{
    public class XenaAppSubscriberRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/XenaAppSubscriber"</summary>
        public const string Base = "Fiscal/{fiscalId}/XenaAppSubscriber";

        /// <summary>""</summary>
        public const string GetList = "";

        /// <summary>"~/Fiscal/{fiscalId}/XenaAppSubscriber/{id}"</summary>
        public const string GetXenaAppSubscriber = "~/Fiscal/{fiscalId}/XenaAppSubscriber/{id}";

        /// <summary>"~/Fiscal/{fiscalId}/XenaAppBundleSubscriber/{id}"</summary>
        public const string GetXenaAppBundleSubscriber = "~/Fiscal/{fiscalId}/XenaAppBundleSubscriber/{id}";

        /// <summary>"~/Fiscal/{fiscalId}/XenaApp/{id}/Subscriber"</summary>
        public const string GetByXenaAppList = "~/Fiscal/{fiscalId}/XenaApp/{id}/Subscriber";

        /// <summary>"~/Fiscal/{fiscalId}/XenaApp/{id}/Users"</summary>
        public const string GetUsersForXenaAppList = "~/Fiscal/{fiscalId}/XenaApp/{id}/Users";

        /// <summary>"~/Fiscal/{fiscalId}/XenaApp/{id}/Subscribe"</summary>
        public const string PutSubscribe = "~/Fiscal/{fiscalId}/XenaApp/{id}/Subscribe";

        /// <summary>"~/Fiscal/{fiscalId}/XenaApp/{id}/Unsubscribe"</summary>
        public const string DeleteUnsubscribe = "~/Fiscal/{fiscalId}/XenaApp/{id}/Unsubscribe";

        /// <summary>"CurrentUser/Apps"</summary>
        public const string GetForCurrentUserList = "CurrentUser/Apps";

        /// <summary>"~/Fiscal/{fiscalId}/XenaApp/{id}/RemoveAppExpireDate"</summary>
        public const string PutRemoveAppExpireDate = "~/Fiscal/{fiscalId}/XenaApp/{id}/RemoveAppExpireDate";

    }
}