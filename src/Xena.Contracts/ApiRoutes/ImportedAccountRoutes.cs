namespace Xena.Contracts.ApiRoutes
{
    public class ImportedAccountRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/ImportedAccount"</summary>
        public const string Base = "Fiscal/{fiscalId}/ImportedAccount";

        /// <summary>"~/Fiscal/{fiscalId}/LedgerTag/{id}/ImportedAccount"</summary>
        public const string GetByLedgerTag = "~/Fiscal/{fiscalId}/LedgerTag/{id}/ImportedAccount";

        /// <summary>"ImportMultiple"</summary>
        public const string PostImportMultiple = "ImportMultiple";
    }
}