namespace Xena.Contracts.ApiRoutes
{
    public class PartnerLocationRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/PartnerLocaiton"</summary>
        public const string Base = "Fiscal/{fiscalId}/PartnerLocation";

        /// <summary>"~/Fiscal/{fiscalId}/Partner/{id}/Location"</summary>
        public const string GetByPartner = "~/Fiscal/{fiscalId}/Partner/{id}/Location";

        /// <summary>"~/Fiscal/{fiscalId}/Partner/{id}/Location"</summary>
        public const string PutRequestLocation = "~/Fiscal/{fiscalId}/Partner/{id}/Location";
    }
}