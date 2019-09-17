namespace Xena.Contracts.ApiRoutes
{
    public class UserRoutes : BaseRoutes
    {
        /// <summary>"User"</summary>
        public const string Base = "User";

        /// <summary>"User/VCard"</summary>
        public const string BaseVCard = Base + "/VCard";

        /// <summary>"Subscription/{id}/XenaUserPartnerPost"</summary>
        public const string GetXenaUserPartnerPostForSubscriptionList = "Subscription/{id}/XenaUserPartnerPost";

        /// <summary>"ClientAuthorization"</summary>
        public const string GetXenaUserClientAuthorizationList = "ClientAuthorization";

        /// <summary>"ClientAuthorization/{id}"</summary>
        public const string GetXenaUserClientAuthorization = "ClientAuthorization/{id}";

        /// <summary>"FiscalSetup/{id}/SharedDocument"</summary>
        public const string GetSharedDocumentListForFiscalSetup = "FiscalSetup/{id}/SharedDocument";

        /// <summary>"UpdateLastFiscalId"</summary>
        public const string PostUpdateXenaUserLastFiscalId = "UpdateLastFiscalId";

        /// <summary>"FiscalSetup/{id}/XenaUserPartnerPost"</summary>
        public const string GetXenaUserPartnerPostForFiscalSetupList = "FiscalSetup/{id}/XenaUserPartnerPost";

        /// <summary>"FiscalSetup/{id}/XenaUserSubscription"</summary>
        public const string GetXenaUserSubscriptionForFiscalSetupList = "FiscalSetup/{id}/XenaUserSubscription";

        /// <summary>"AlternateIdentification"</summary>
        public const string PostAlternateIdentification = "AlternateIdentification";

        /// <summary>"User/{id}/VCard"</summary>
        public const string GetVCardForUser = "VCardForUser";

        /// <summary>"VCard"</summary>
        public const string GetVCard = "VCard/{id}";

        /// <summary>"VCard"</summary>
        public const string PostVCard = "VCard";

        /// <summary>"VCard/{id}"</summary>
        public const string PutVCard = "VCard/{id}";

        /// <summary>"VCard/{id}"</summary>
        public const string DeleteVCard = "VCard/{id}";

        /// <summary>"ExecuteNotification"</summary>
        public const string PutExecuteNotification = "Notification/{id}/Execute";

        /// <summary>"XenaUserPartner"</summary>
        public const string GetXenaUserPartnerList = "XenaUserPartner";

        /// <summary>"AuthenticatedEmails"</summary>
        public const string GetAuthenticatedEmails = "AuthenticatedEmails";

        /// <summary>"XenaSubscriptionTicket"</summary>
        public const string GetXenaUserSubscriptionTicket = "XenaUserSubscriptionTicket";

        /// <summary>"Subscription/{id}/SubscriptionTicket"</summary>
        public const string GetSubscriptionTicket = "Subscription/{id}/SubscriptionTicket";

        /// <summary>"FiscalSetup/{id}/AllowingOnlinePayment"</summary>
        public const string GetAllowingOnlinePaymentOnFiscalSetup = "FiscalSetup/{id}/AllowingOnlinePayment";

        /// <summary>"InvitingPartnerVCard"</summary>
        public const string GetInvitingPartnerVCardList = "InvitingPartnerVCard";

        /// <summary>"InvitingFiscalSetupVCard"</summary>
        public const string GetInvitingFiscalSetupVCardList = "InvitingFiscalSetupVCard";

        /// <summary>"FiscalSetup"</summary>
        public const string GetFiscalSetupList = "FiscalSetup";

        /// <summary>"VersionAndPicture"</summary>
        public const string GetVersionAndPicture = "VersionAndPicture";

        /// <summary>"UserNotificationCount"</summary>
        public const string GetUserNotificationCount = "UserNotificationCount";

        /// <summary>"CheckSPF"</summary>
        public const string PostCheckSPF = "CheckSPF";

        /// <summary>"ImportC5"</summary>
        public const string PostImportC5 = "ImportC5";

        /// <summary>"XenaUserMembership"</summary>
        public const string GetXenaUserMembershipList = "XenaUserMembership";

        /// <summary>"IdsUserMembership"</summary>
        public const string GetIdSMembershipList = "IdsUserMembership";

        /// <summary>"History"</summary>
        public const string GetHistory = "History";

        /// <summary>"Fiscal/{id}/ConnectionData"</summary>
        public const string GetConnectionDataForFiscal = "Fiscal/{id}/ConnectionData";

        /// <summary>"EpayTicketForExistingUserSubscription"</summary>
        public const string PostEpayTicketForExistingUserSubscription = "EpayTicketForExistingUserSubscription";

        /// <summary>"XenaUserSubscription/{id}/XenaUserSubscriptionLine"</summary>
        public const string GetXenaUserSubscriptionLineList = "XenaUserSubscription/{id}/XenaUserSubscriptionLine";

    }
}