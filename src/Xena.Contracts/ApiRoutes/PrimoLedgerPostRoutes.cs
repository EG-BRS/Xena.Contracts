namespace Xena.Contracts.ApiRoutes
{
    public class PrimoLedgerPostRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/PrimoLedgerPost"</summary>
        public const string Base = "Fiscal/{fiscalId}/PrimoLedgerPost";

        /// <summary>"~/Fiscal/{fiscalId}/FiscalPeriod/{id}/PrimoLedgerPost"</summary>
        public const string GetByFiscalPeriodList = "~/Fiscal/{fiscalId}/FiscalPeriod/{id}/PrimoLedgerPost";
    }
}