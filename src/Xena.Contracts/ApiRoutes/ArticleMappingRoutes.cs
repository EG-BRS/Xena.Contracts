namespace Xena.Contracts.ApiRoutes
{
    public class ArticleMappingRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/ArticleMapping"</summary>
        public const string Base = "Fiscal/{fiscalId}/ArticleMapping";

        /// <summary>"~/Fiscal/{fiscalId}/Article/{id}/ArticleMapping"</summary>
        public const string GetByArticleList = "~/Fiscal/{fiscalId}/Article/{id}/ArticleMapping";

        /// <summary>"~/Fiscal/{fiscalId}/Partner/{id}/ArticleMapping"</summary>
        public const string GetByPartnerList = "~/Fiscal/{fiscalId}/Partner/{id}/ArticleMapping";

        /// <summary>"~/Fiscal/{fiscalId}/Article/{id}/Partner/{partnerId}/Mapping"</summary>
        public const string GetByPartnerAndArticleList = "~/Fiscal/{fiscalId}/Article/{id}/Partner/{partnerId}/Mapping";

        /// <summary>"~/Fiscal/{fiscalId}/Partner/{partnerId}/ArticleMapping/Multiple"</summary>
        public const string PostMultiple = "~/Fiscal/{fiscalId}/Partner/{partnerId}/ArticleMapping/Multiple";
    }
}