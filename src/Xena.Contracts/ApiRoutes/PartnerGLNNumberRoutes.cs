namespace Xena.Contracts.ApiRoutes
{
    public class PartnerGLNNumberRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/PartnerGLNNumber"</summary>
        public const string Base = "Fiscal/{fiscalId}/PartnerGLNNumber";

        /// <summary>"~/Fiscal/{fiscalId}/Partner/{id}/GLNNumber"</summary>
        public const string GetByPartnerList = "~/Fiscal/{fiscalId}/Partner/{id}/GLNNumber";
    }
}