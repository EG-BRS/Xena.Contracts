namespace Xena.Contracts.ApiRoutes.Chart
{
    public class FiscalPeriodChartRoutes
    {
        /// <summary>"Api/Fiscal/{fiscalId}/Chart/FiscalPeriod/{id}"</summary>
        public const string Base = "Api/Fiscal/{fiscalId}/Chart/FiscalPeriod/{id}";

        /// <summary>"Statistics"</summary>
        public const string GetStatistics = "Statistics";

        /// <summary>"Dashboard"</summary>
        public const string GetDashboard = "Dashboard";

        /// <summary>"LedgerAccount/{ledgerAccount}/Statistics"</summary>
        public const string GetLedgerAccountStatistics = "LedgerAccount/{ledgerAccount}/Statistics";

    }
}