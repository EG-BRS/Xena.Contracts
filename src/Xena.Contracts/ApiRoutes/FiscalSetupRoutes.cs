namespace Xena.Contracts.ApiRoutes
{
    public class FiscalSetupRoutes
    {
        /// <summary>"Api/Fiscal/{fiscalId}/FiscalSetup"</summary>
        public const string Base = "Api/Fiscal/{fiscalId}/FiscalSetup";

        /// <summary>"/VCard"</summary>
        public const string BaseVCard = Base + "/VCard";

        /// <summary>"DeleteLogo"</summary>
        public const string DeleteLogo = "Logo";

        /// <summary>"/Location"</summary>
        public const string BaseLocation = Base + "/Location";

        /// <summary>"XenaFiscalSubscription"</summary>
        public const string BaseXenaSubcription = Base + "/XenaSubscription";

        /// <summary>"XenaFiscalSubscriptionTicket"</summary>
        public const string BaseXenaFiscalSubscriptionTicket = Base + "/XenaFiscalSubscriptionTicket";

        /// <summary>"/Membership"</summary>
        public const string BaseMembership = Base + "/Membership";

        /// <summary>""</summary>
        public const string Get = "";

        /// <summary>""</summary>
        public const string GetXenaAppList = "XenaApps";

        /// <summary>""</summary>
        public const string Put = "";

        /// <summary>""</summary>
        public const string Delete = "";

        /// <summary>"SecurityRole"</summary>
        public const string GetSecurityRoleList = "SecurityRole";

        /// <summary>"Subscription/{id}/SubscriptionTicket"</summary>
        public const string GetSubscriptionTicket = "Subscription/{id}/SubscriptionTicket";

        /// <summary>"Membership/{id}/SecurityRole"</summary>
        public const string GetMembershipSecurityRole = "Membership/{id}/SecurityRole";

        /// <summary>"XenaSubscriptionPrice"</summary>
        public const string GetXenaSubscriptionPrice = "XenaSubscriptionPrice";

        /// <summary>"{id}/XenaSubscriptionPrice"</summary>
        public const string GetXenaSubscriptionPriceById = "{id}/XenaSubscriptionPrice";

        /// <summary>"VCard"</summary>
        public const string GetVCard = "VCard/{id}";

        /// <summary>"VCard"</summary>
        public const string PostVCard = "VCard";

        /// <summary>"VCard/{id}"</summary>
        public const string PutVCard = "VCard/{id}";

        /// <summary>"VCard/{id}"</summary>
        public const string DeleteVCard = "VCard/{id}";

        /// <summary>"VCardByFiscalSetup"</summary>
        public const string GetVCardByFiscalSetup = "VCardByFiscalSetup";

        /// <summary>"Location"</summary>
        public const string GetLocation = "Location/{id}";

        /// <summary>"Location/{id}"</summary>
        public const string PutLocation = "Location/{id}";

        /// <summary>"LocationByFiscalSetup"</summary>
        public const string GetLocationByFiscalSetup = "LocationByFiscalSetup";

        /// <summary>"Subscription/{id}/PartnerPost"</summary>
        public const string GetSubscriptionPartnerPostList = "Subscription/{id}/PartnerPost";

        /// <summary>"Partner/{id}/PartnerPost"</summary>
        public const string GetPartnerPostList = "Partner/{id}/PartnerPost";

        /// <summary>"XenaFiscalSubscriptionTicket/{id}"</summary>
        public const string GetXenaFiscalSubscriptionTicket = "XenaFiscalSubscriptionTicket/{id}";

        /// <summary>"Membership"</summary>
        public const string GetMembershipList = "Membership";

        /// <summary>"Support"</summary>
        public const string GetSupportList = "Support";

        /// <summary>"InviteUser"</summary>
        public const string PostInviteUser = "User/{id}/Invite";

        /// <summary>"InviteUserByEmail"</summary>
        public const string PostInviteUserByEmail = "InviteUserByEmail";

        /// <summary>"CreateApiUser"</summary>
        public const string PostCreateApiUser = "CreateApiUser";

        /// <summary>"RequestGeoLocation"</summary>
        public const string PutRequestGeoLocation = "RequestGeoLocation";

        /// <summary>"SwitchToFullFiscal"</summary>
        public const string PutSwitchToFullFiscal = "SwitchToFullFiscal";

        /// <summary>"CreateISO"</summary>
        public const string PostCreateISO = "CreateISO";

        /// <summary> "Membership/{id}/ChangeSecurityGroup"</summary>
        public const string PutChangeSecurityGroup = "Membership/{id}/ChangeSecurityGroup";

        /// <summary>"Membership/{id}/ManageApps"</summary>
        public const string PutManageApps = "Membership/{id}/ManageApps";

        /// <summary>"Membership/{id}"</summary>
        public const string DeleteMembership = "Membership/{id}";

        /// <summary>"Membership/{id}"</summary>
        public const string GetMembership = "Membership/{id}";

        /// <summary>"RequestSproomAccount"</summary>
        public const string PostRequestSproomAccount = "RequestSproomAccount";

        /// <summary>"SproomSetup"</summary>
        public const string PutSproomAccount = "SproomSetup";

        /// <summary>"SproomSetup"</summary>
        public const string DeleteSproomAccount = "SproomSetup";

        /// <summary>"XenaSubscription"</summary>
        public const string GetXenaSubscriptionForCurrentFiscal = "XenaSubscription";

        /// <summary>"XenaSubscription/{id}"</summary>
        public const string GetXenaSubscription = "XenaSubscription/{id}";

        /// <summary>"RequestPremium"</summary>
        public const string PutRequestPremium = "RequestPremium";

        /// <summary>"DowngradeFree"</summary>
        public const string PutDowngradeFree = "DowngradeFree";

        /// <summary>"UpdateVCardPicture"</summary>
        public const string PutUpdateVCardPicture = "UpdateVCardPicture";

        /// <summary>"ApiKeys"</summary>
        public const string GetApiKeyList = "ApiKeys";

        /// <summary>"VirtualUser"</summary>
        public const string GetVirtualUserList = "VirtualUser";

        /// <summary>"FiscalNotificationCount"</summary>
        public const string GetFiscalNotificationCount = "FiscalNotificationCount";

        /// <summary>"ImportFromBillysBilling"</summary>
        public const string PostImportFromBillysBilling = "ImportFromBillysBilling";

        /// <summary>"ImportFromEconomic/{token}"</summary>
        public const string PostImportFromEconomic = "ImportFromEconomic/{token}";

        /// <summary>"Menu"</summary>
        public const string GetMenu = "Menu";

        /// <summary>"InstalledApps"</summary>
        public const string GetInstalledApps = "InstalledApps";

        /// <summary>"Copy"</summary>
        public const string PostCopy = "Copy";

        /// <summary>"ImportManually"</summary>
        public const string PostImportManually = "ImportManually";

        /// <summary>"DeleteArchive"</summary>
        public const string DeleteArchive = "DeleteArchive";

        /// <summary>"ResetDataImportTask"</summary>
        public const string DeleteResetDataImportTask = "ResetDataImportTask";

        /// <summary>"Accountant/{accountantId}"</summary>
        public const string PutAccountant = "Accountant/{accountantId}";

        /// <summary>"Transfer/{userId}"</summary>
        public const string PostTransferMembership = "Transfer/{userId}";

        /// <summary>"TransferToEmail"</summary>
        public const string PostTransferMembershipToEmail = "TransferToEmail";

        /// <summary>"UpdateFiscalSetupAccountant"</summary>
        public const string PutUpdateFiscalSetupAccountant = "UpdateFiscalSetupAccountant";

        /// <summary>"TestXenaSubscription"</summary>
        public const string PostCreateTestXenaSubscription = "TestXenaSubscription";

        /// <summary>"XenaSubscriptionData"</summary>
        public const string GetXenaSubscriptionData = "XenaSubscriptionData";

        /// <summary>"FiscalSetup/{id}/XenaFiscalSubscription"</summary>
        public const string GetXenaFiscalSubscriptionForFiscalList = "FiscalSetup/{id}/XenaFiscalSubscription";

        /// <summary>"FiscalSetup/{id}/XenaFiscalPartnerPost"</summary>
        public const string GetXenaFiscalPartnerPostForFiscalList = "FiscalSetup/{id}/XenaFiscalPartnerPost";

        /// <summary>"Fiscal/{id}/ConnectionData"</summary>
        public const string GetConnectionDataForFiscal = "Fiscal/{id}/ConnectionData";

        /// <summary>"UserData/{id}"</summary>
        public const string GetConnectionDataForUser = "UserData/{id}";

        /// <summary>"MD5Key"</summary>
        public const string PostMD5Key = "MD5Key";

        /// <summary>"EpayData"</summary>
        public const string PostEpayData = "EpayData";

        /// <summary>"EpayDataForBlankSubscription"</summary>
        public const string PostEpayDataForBlankSubscription = "EpayDataForBlankSubscription";

        /// <summary>"RequestPremiumByEpay"</summary>
        public const string PostRequestPremiumByEpay = "RequestPremiumByEpay";


        /// <summary>"EpayTicketForExistingFiscalSubscription"</summary>
        public const string PostEpayTicketForExistingFiscalSubscription = "EpayTicketForExistingFiscalSubscription";

        /// <summary>"EpayDataForOnlineFiscalPayment"</summary>
        public const string PostEpayDataForOnlineFiscalPayment = "EpayDataForOnlineFiscalPayment";

        /// <summary>"OutstandingPayment"</summary>
        public const string GetOutstandingPayment = "OutstandingPayment";

        /// <summary>"Statistics"</summary>
        public const string GetStatistics = "Statistics";

        /// <summary>"RedeemDiscountCode"</summary>
        public const string PostRedeemDiscountCode = "RedeemDiscountCode";

        /// <summary>"UsedDiscountCodes"</summary>
        public const string GetUsedDiscountCodes = "UsedDiscountCodes";

        /// <summary>"HasValidXenaPayment"</summary>
        public const string GetHasValidXenaPayment = "HasValidXenaPayment";

        /// <summary>"FiscalDiscounts"</summary>
        public const string GetFiscalDiscounts = "FiscalDiscounts";
    }
}