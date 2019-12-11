namespace Xena.Contracts.ApiRoutes
{
    public class ArticleLocationSetupRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/ArticleLocationSetup"</summary>
        public const string Base = "Fiscal/{fiscalId}/ArticleLocationSetup";

        /// <summary>"~/Fiscal/{fiscalId}/Article/{id}/LocationSetup"</summary>
        public const string GetByArticleList = "~/Fiscal/{fiscalId}/Article/{id}/LocationSetup";

        /// <summary>"~/Fiscal/{fiscalId}/Location/{id}/ArticleSetup"</summary>
        public const string GetByLocationList = "~/Fiscal/{fiscalId}/Location/{id}/ArticleSetup";

        /// <summary>"/Multiple"</summary>
        public const string PostMultiple = "Multiple";
    }
}