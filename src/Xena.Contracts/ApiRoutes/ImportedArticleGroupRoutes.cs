namespace Xena.Contracts.ApiRoutes
{
    public class ImportedArticleGroupRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/ImportedArticleGroup"</summary>
        public const string Base = "Fiscal/{fiscalId}/ImportedArticleGroup";

        /// <summary>"{id}/LinkArticles"</summary>
        public const string PutImportGroup = "{id}/LinkArticles";

        /// <summary>"ImportMultiple"</summary>
        public const string PostImportMultiple = "ImportMultiple";

    }
}