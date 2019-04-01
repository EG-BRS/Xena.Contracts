namespace Xena.Contracts.ApiRoutes
{
    public class PartnerResourceContextRoutes : BaseRoutes
    {
        public const string Base = "Fiscal/{fiscalId}/Resource";

        /// <summary>"/VCard"</summary>
        public const string BaseVCard = Base + "/VCard";

        /// <summary>"Finance"</summary>
        public const string GetForFinance = "Finance";

        /// <summary>"Order"</summary>
        public const string GetForOrder = "Order";

        /// <summary>"Scheduling"</summary>
        public const string GetForScheduling = "Scheduling";

        /// <summary>"{id}/MembershipData"</summary>
        public const string GetMembershipData = "{id}/MembershipData";

        /// <summary>"ResourceVCard"</summary>
        public const string GetResourceVCard = "{id}/ResourceVCard";

        /// <summary>"BreakSetup"</summary>
        public const string GetBreakSetup = "{id}/BreakSetup";

        /// <summary>"Route"</summary>
        public const string GetResourceVCardList = "ResourceVCard";

        /// <summary>"VCard"</summary>
        public const string GetVCard = "VCard/{id}";

        /// <summary>"VCard"</summary>
        public const string PostVCard = "VCard";

        /// <summary>"VCard/{id}"</summary>
        public const string PutVCard = "VCard/{id}";

        /// <summary>"VCard/{id}"</summary>
        public const string DeleteVCard = "VCard/{id}";

        /// <summary>"~/Fiscal/{fiscalId}/Partner/{id}/ResourceContext"</summary>
        public const string GetByPartner = "~/Fiscal/{fiscalId}/Partner/{id}/ResourceContext";

        /// <summary>"{id}/GenerateApiKey"</summary>
        public const string PutGenerateApiKey = "{id}/GenerateApiKey";

        /// <summary>"Theme"</summary>
        public const string GetTheme = "Theme";

        /// <summary>"{id}/BookkeepingAccess"</summary>
        public const string GetBookkeepingAccess = "{id}/BookkeepingAccess";

        /// <summary>"WorkhoursForDate"</summary>
        public const string GetWorkhoursForDate = "WorkhoursForDate";


    }
}