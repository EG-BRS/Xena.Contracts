namespace Xena.Contracts.ApiRoutes
{
    public class VCardRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/VCard"</summary>
        public const string Base = "Fiscal/{fiscalId}/VCard";

        /// <summary>"ByPartner/{partnerId}"</summary>
        public const string GetByPartnerList = "ByPartner/{partnerId}";

        /// <summary>"ByType"</summary>
        public const string GetByTypeList = "ByType";

        /// <summary>"ByEmail"</summary>
        public const string GetByEmailList = "ByEmail";

        /// <summary>"UserSearch"</summary>
        public const string GetUserSearch = "UserSearch";
    }
}