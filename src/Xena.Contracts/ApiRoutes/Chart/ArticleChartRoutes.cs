namespace Xena.Contracts.ApiRoutes.Chart
{
    public class ArticleChartRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/Chart/Article/{id}"</summary>
        public const string Base = "Fiscal/{fiscalId}/Chart/Article/{id}";

        /// <summary>"AveragePriceDevelopement"</summary>
        public const string GetAveragePriceDevelopement = "AveragePriceDevelopement";

        /// <summary>"HistoricStock"</summary>
        public const string GetHistoricStock = "HistoricStock";

        /// <summary>"Turnover"</summary>
        public const string GetTurnover = "Turnover";

    }
}