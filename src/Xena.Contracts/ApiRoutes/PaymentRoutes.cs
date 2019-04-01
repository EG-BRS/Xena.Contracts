namespace Xena.Contracts.ApiRoutes
{
    public class PaymentRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/Payment"</summary>
        public const string Base = "Fiscal/{fiscalId}/Payment";

        /// <summary>"PartnerPayment"</summary>
        public const string GetPartnerPaymentList = "PartnerPayment";

        /// <summary>"PartnerPaymentByIds"</summary>
        public const string GetPartnerPaymentByIdsList = "PartnerPaymentByIds";

        /// <summary>"~/Fiscal/{fiscalId}/Partner/{id}/UnsettledPost"</summary>
        public const string GetUnsettledPartnerPost = "~/Fiscal/{fiscalId}/Partner/{id}/UnsettledPost";

        /// <summary>"RetryPayments"</summary>
        public const string PutRetryPayments = "RetryPayments";

        /// <summary>"~/Fiscal/{fiscalId}/Order/{id}/UnsettledPost"</summary>
        public const string GetUnsettledPartnerPostForOrder = "~/Fiscal/{fiscalId}/Order/{id}/UnsettledPost";

        /// <summary>"Settlment/{id}"</summary>
        public const string DeleteSettlement = "Settlment/{id}";

        /// <summary>"Settlment/{id}"</summary>
        public const string SettlementBase = "Settlment";

        /// <summary>"Export"</summary>
        public const string PostExport = "Export";

        /// <summary>"UnsettledPost"</summary>
        public const string GetUnsettledPost = "UnsettledPost";
    }
}