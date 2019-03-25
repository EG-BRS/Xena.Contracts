namespace Xena.Contracts.ApiRoutes
{
    public static class PartnerPostPaymentRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/BankExport"</summary>
        public const string Base = "Fiscal/{fiscalId}/PartnerPostPayment";

        /// <summary>"~/Fiscal/{fiscalId}/BankExport/{bankExportId}/PartnerPostPayment"</summary>
        public const string GetByBankExport = "~/Fiscal/{fiscalId}/BankExport/{bankExportId}/PartnerPostPayment";
    }
}