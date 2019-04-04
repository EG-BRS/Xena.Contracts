namespace Xena.Contracts.ApiRoutes
{
    public class ProjectRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/Project"</summary>
        public const string Base = "Fiscal/{fiscalId}/Project";

        /// <summary>"History"</summary>
        public const string GetHistory = "History";

        /// <summary>"Favorite"</summary>
        public const string GetFavorite = "Favorite";

        /// <summary>"ProjectsForStatus/{id}"</summary>
        public const string GetProjectsForStatus = "ProjectsForStatus/{id}";

        /// <summary>"Statistics/Closed"</summary>
        public const string GetClosedProjectStatistics = "Statistics/Closed";

        /// <summary>"Statistics/CostType"</summary>
        public const string GetCostTypeStatistics = "Statistics/CostType";

        /// <summary>"Statistics/Favorites"</summary>
        public const string GetFavoritesProjectStatistics = "Statistics/Favorites";

        /// <summary>"Statistics/Inbox"</summary>
        public const string GetResourceInboxStatisticsData = "Statistics/Inbox";

        /// <summary>"Closed"</summary>
        public const string GetClosed = "Closed";

        /// <summary>"Open"</summary>
        public const string GetOpen = "Open";

        /// <summary>"{id}/GetProjectStatisticsData"</summary>
        public const string GetProjectStatisticsData = "{id}/GetProjectStatisticsData";

        /// <summary>"{id}/MarkFavorite"</summary>
        public const string PutMarkFavorite = "{id}/MarkFavorite";

        /// <summary>"{id}/RemoveFavorite"</summary>
        public const string DeleteMarkFavorite = "{id}/RemoveFavorite";

    }
}