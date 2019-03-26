namespace Xena.Contracts.ApiRoutes.Chart
{
    public class SubscriptionChartRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/Chart/Subscription/{id}"</summary>
        public const string Base = "Fiscal/{fiscalId}/Chart/Subscription";

        /// <summary>"ArticleGroupTotals"</summary>
        public const string GetTotalsByArticleGroup = "ArticleGroupTotals";

        /// <summary>"{id}/ByArticle"</summary>
        public const string GetByArticle = "ArticleGroup/{articleGroupId}/ByArticle";

        /// <summary>"Forecast"</summary>
        public const string GetForecast = "Forecast";

        /// <summary>"Development"</summary>
        public const string GetDevelopment = "Development";
    }
}