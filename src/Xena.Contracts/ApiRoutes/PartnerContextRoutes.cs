namespace Xena.Contracts.ApiRoutes
{
    public class PartnerContextRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/PartnerContext"</summary>
        public const string Base = "Fiscal/{fiscalId}/PartnerContext";

        /// <summary>"~/Fiscal/{fiscalId}/Partner/{id}/Context"</summary>
        public const string GetByPartner = "~/Fiscal/{fiscalId}/Partner/{id}/Context";

        /// <summary>"~/Fiscal/{fiscalId}/Partner/{id}/Context/{contextType}"</summary>
        public const string GetByPartnerAndContextType = "~/Fiscal/{fiscalId}/Partner/{id}/Context/{contextType}";
    }
}