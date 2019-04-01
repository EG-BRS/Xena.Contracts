namespace Xena.Contracts.ApiRoutes
{
    public class PartiallyPaidPartnerPostRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/PartiallyPaidPartnerPost"</summary>
        public const string Base = "Fiscal/{fiscalId}/PartiallyPaidPartnerPost";

        /// <summary>"~/Fiscal/{fiscalId}/PartnerPost/{id}/PartiallyPaid"</summary>
        public const string GetListForPartnerPost = "~/Fiscal/{fiscalId}/PartnerPost/{id}/PartiallyPaid";
    }
}