namespace Xena.Contracts.ApiRoutes
{
    public class ImportedPostingRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/ImportedPosting"</summary>
        public const string Base = "Fiscal/{fiscalId}/ImportedPosting";

        /// <summary>"Fiscal/{fiscalId}/ImportedAccount/{id}/ImportedPosting"</summary>
        public const string GetImportedPostingListForAccount = "~/Fiscal/{fiscalId}/ImportedAccount/{id}/ImportedPosting";
         
        /// <summary>"ImportMultiple"</summary>
        public const string PostImportMultiple = "ImportMultiple";
         
    }
}