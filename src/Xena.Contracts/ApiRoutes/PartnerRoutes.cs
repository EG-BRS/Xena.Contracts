namespace Xena.Contracts.ApiRoutes
{
    public class PartnerRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/Partner"</summary>
        public const string Base = "Fiscal/{fiscalId}/Partner";

        /// <summary>"Fiscal/{fiscalId}/Partner/PartnerPost"</summary>
        public const string BasePartnerPost = Base + "/PartnerPost";

        /// <summary>"PartnerPost/{id}"</summary>
        public const string PutPartnerPost = "PartnerPost/{id}";

        /// <summary>"ByAccountNumber/{accountNumber}"</summary>
        public const string GetByAccountNumber = "ByAccountNumber/{accountNumber}";

        /// <summary>"Search"</summary>
        public const string PostFromSearch = "Search";

        /// <summary>"Old/Search"</summary>
        public const string PostObsoleteFromSearch = "Old/Search";

        /// <summary>"Old/ResetNumberSeries"</summary>
        public const string PutObsoleteResetNumberSeries = "Old/ResetNumberSeries";

        /// <summary>"~/Fiscal/{fiscalId}/VCard/{id}/Partner"</summary>
        public const string PostFromVCard = BaseFiscalUri + "VCard/{id}/Partner";

        /// <summary>"~/Fiscal/{fiscalId}/FiscalSetup/{id}/Partner"</summary>
        public const string PostFromFiscalSetup = BaseFiscalUri + "FiscalSetup/{id}/Partner";

        /// <summary>"Search"</summary>
        public const string GetSearch = "Search";

        /// <summary>"XenaFiscalSubscription"</summary>
        public const string GetXenaFiscalSubscriptionList = "{id}/XenaFiscalSubscription";

        /// <summary>"{id}/PartnerHistoryEntry"</summary>
        public const string GetHistoryEntry = "{id}/PartnerHistoryEntry";

        /// <summary>"{id}/FromOrder/{orderId}"</summary>
        public const string PutFromOrder = "{id}/FromOrder/{orderId}";

        /// <summary>"{partnerToDeactivateId}/MergeInto/{partnerToKeepId}"</summary>
        public const string DeleteMergeInto = "{partnerToDeactivateId}/MergeInto/{partnerToKeepId}";

        /// <summary>"History"</summary>
        public const string GetHistory = "History";

        /// <summary>"{id}/Disconnect"</summary>
        public const string PutDisconnect = "{id}/Disconnect";

        /// <summary>"{id}/Invite"</summary>
        public const string PutInvite = "{id}/Invite";

        /// <summary>"{id}/LinkVCard/{vCardId}"</summary>
        public const string PutLinkVCard = "{id}/LinkVCard/{vCardId}";

        /// <summary>"{id}/Balance"</summary>
        public const string GetBalance = "{id}/Balance";

        /// <summary>"{id}/InvoiceEmail"</summary>
        public const string PutInvoiceEmail = "{id}/InvoiceEmail";

        /// <summary>"Tag"</summary>
        public const string GetTag = "Tag";

        /// <summary>"ContextType"</summary>
        public const string GetContextType = "ContextType";

        /// <summary>"ScheduleMethods"</summary>
        public const string GetScheduleMethods = "ScheduleMethods";

        /// <summary>"PartnerType"</summary>
        public const string GetPartnerType = "PartnerType";

        /// <summary>"{id}/Search"</summary>
        public const string GetSearchWithoutPartner = "{id}/Search";

        /// <summary>"{id}/PartnerInviteHistoryEntry"</summary>
        public const string GetPartnerInviteHistoryEntry = "{id}/PartnerInviteHistoryEntry";

        /// <summary>"{id}/PartnerInviteHistoryEntry"</summary>
        public const string DeletePartnerInviteHistoryEntry = "{id}/PartnerInviteHistoryEntry";

        /// <summary>"{id}/ResendPartnerInvitation"</summary>
        public const string PutResendPartnerInvitation = "{id}/ResendPartnerInvitation/{partnerInvitationId}";

        /// <summary>"~/Fiscal/{fiscalId}/PriceGroup/{id}/Partner"</summary>
        public const string GetByPriceGroupList = BaseFiscalUri + "PriceGroup/{id}/Partner";

        /// <summary>"PartnerContextType"</summary>
        public const string GetPartnerContextType = "PartnerContextType";

        /// <summary>"Partner/{id}/ConnectionData"</summary>
        public const string GetConnectionDataForPartner = "Partner/{id}/ConnectionData";

    }
}