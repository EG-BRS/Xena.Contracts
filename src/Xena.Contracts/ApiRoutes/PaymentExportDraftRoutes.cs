namespace Xena.Contracts.ApiRoutes
{
    public class PaymentExportDraftRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/Payment"</summary>
        public const string Base = "Fiscal/{fiscalId}/PaymentExportDraft";

        /// <summary>"ByPaymentIds"</summary>
        public const string GetByPaymentIdsList = "{contextId}/ByPaymentIds";
    }
}