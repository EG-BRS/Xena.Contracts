namespace Xena.Contracts.ApiRoutes
{
    public class ImportedArticleGroupRoutes : BaseRoutes
    {
        /// <summary>"Api/Fiscal/{fiscalId}/ImportedArticleGroup"</summary>
        public const string Base = "Api/Fiscal/{fiscalId}/ImportedArticleGroup";

        /// <summary>"{id}/LinkArticles"</summary>
        public const string PutImportGroup = "{id}/LinkArticles";

        /// <summary>"ImportMultiple"</summary>
        public const string PostImportMultiple = "ImportMultiple";

    }
}