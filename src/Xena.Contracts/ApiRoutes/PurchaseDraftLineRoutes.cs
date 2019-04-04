namespace Xena.Contracts.ApiRoutes
{
    public class PurchaseDraftLineRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/PurchaseDraftLine"</summary>
        public const string Base = "Fiscal/{fiscalId}/PurchaseDraftLine";

        /// <summary>"~/Fiscal/{fiscalId}/PurchaseDraft/{id}/Lines"</summary>
        public const string GetByPurchaseDraft = "~/Fiscal/{fiscalId}/PurchaseDraft/{id}/Lines";
    }
}