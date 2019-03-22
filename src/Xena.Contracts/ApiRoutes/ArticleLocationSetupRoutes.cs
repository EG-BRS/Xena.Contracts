namespace Xena.Contracts.ApiRoutes
{
    public class ArticleLocationSetupRoutes : BaseRoutes
    {
        /// <summary>"Api/Fiscal/{fiscalId}/ArticleLocationSetup"</summary>
        public const string Base = "Api/Fiscal/{fiscalId}/ArticleLocationSetup";

        /// <summary>"~/Api/Fiscal/{fiscalId}/Article/{id}/LocationSetup"</summary>
        public const string GetByArticleList = "~/Api/Fiscal/{fiscalId}/Article/{id}/LocationSetup";

        /// <summary>"~/Api/Fiscal/{fiscalId}/Location/{id}/ArticleSetup"</summary>
        public const string GetByLocationList = "~/Api/Fiscal/{fiscalId}/Location/{id}/ArticleSetup";
    }
}