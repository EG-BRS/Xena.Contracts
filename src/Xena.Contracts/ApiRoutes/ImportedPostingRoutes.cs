namespace Xena.Contracts.ApiRoutes
{
    public class ImportedPostingRoutes : BaseRoutes
    {
        /// <summary>"Api/Fiscal/{fiscalId}/ImportedPosting"</summary>
        public const string Base = "Api/Fiscal/{fiscalId}/ImportedPosting";

        /// <summary>"Api/Fiscal/{fiscalId}/ImportedAccount/{id}/ImportedPosting"</summary>
        public const string GetImportedPostingListForAccount = "~/Api/Fiscal/{fiscalId}/ImportedAccount/{id}/ImportedPosting";
         
        /// <summary>"ImportMultiple"</summary>
        public const string PostImportMultiple = "ImportMultiple";
         
    }
}