namespace Xena.Contracts.ApiRoutes
{
    public class ArticleMappingRoutes : BaseRoutes
    {
        /// <summary>"Api/Fiscal/{fiscalId}/ArticleMapping"</summary>
        public const string Base = "Api/Fiscal/{fiscalId}/ArticleMapping";

        /// <summary>"~/Api/Fiscal/{fiscalId}/Article/{id}/ArticleMapping"</summary>
        public const string GetByArticleList = "~/Api/Fiscal/{fiscalId}/Article/{id}/ArticleMapping";

        /// <summary>"~/Api/Fiscal/{fiscalId}/Partner/{id}/ArticleMapping"</summary>
        public const string GetByPartnerList = "~/Api/Fiscal/{fiscalId}/Partner/{id}/ArticleMapping";

        /// <summary>"~/Api/Fiscal/{fiscalId}/Article/{id}/Partner/{partnerId}/Mapping"</summary>
        public const string GetByPartnerAndArticleList = "~/Api/Fiscal/{fiscalId}/Article/{id}/Partner/{partnerId}/Mapping";

        /// <summary>"~/Api/Fiscal/{fiscalId}/Partner/{partnerId}/ArticleMapping/Multiple"</summary>
        public const string PostMultiple = "~/Api/Fiscal/{fiscalId}/Partner/{partnerId}/ArticleMapping/Multiple";
    }
}