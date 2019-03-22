namespace Xena.Contracts.ApiRoutes
{
    public class ImportedAccountRoutes : BaseRoutes
    {
        /// <summary>"Api/Fiscal/{fiscalId}/ImportedAccount"</summary>
        public const string Base = "Api/Fiscal/{fiscalId}/ImportedAccount";

        /// <summary>"~/Api/Fiscal/{fiscalId}/LedgerTag/{id}/ImportedAccount"</summary>
        public const string GetByLedgerTag = "~/Api/Fiscal/{fiscalId}/LedgerTag/{id}/ImportedAccount";

        /// <summary>"ImportMultiple"</summary>
        public const string PostImportMultiple = "ImportMultiple";
    }
}