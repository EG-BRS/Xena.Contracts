namespace Xena.Contracts.ApiRoutes.Chart
{
    public class ProjectChartRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/Chart/Project/{id}"</summary>
        public const string Base = "Fiscal/{fiscalId}/Chart/Project";

        /// <summary>"Totals"</summary>
        public const string GetTotals = "Totals";

        /// <summary>"{id}/FiscalPeriod/{fiscalPeriodId}/Statistics"</summary>
        public const string GetPeriodStatistics = "{id}/FiscalPeriod/{fiscalPeriodId}/Statistics";

        /// <summary>"{id}/Actual"</summary>
        public const string GetActual = "{id}/Actual";

        /// <summary>"{id}/Statistics"</summary>
        public const string GetStatistics = "{id}/Statistics";

        /// <summary>"{id}/Budget"</summary>
        public const string GetBudget = "{id}/Budget";
    }
}