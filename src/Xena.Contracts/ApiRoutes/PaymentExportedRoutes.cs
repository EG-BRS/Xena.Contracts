namespace Xena.Contracts.ApiRoutes
{
    public static class PaymentExportedRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/PaymentExported"</summary>
        public const string Base = "Fiscal/{fiscalId}/PaymentExported";

        /// <summary>"~/Fiscal/{fiscalId}/BankExport/{contextId}/PaymentExported"</summary>
        public const string GetByBankExportList = "~/Fiscal/{fiscalId}/BankExport/{id}/PaymentExported";
    }
}