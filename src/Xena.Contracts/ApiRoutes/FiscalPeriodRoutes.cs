namespace Xena.Contracts.ApiRoutes
{
    public class FiscalPeriodRoutes : BaseRoutes
    {
        /// <summary>"Api/Fiscal/{fiscalId}/FiscalPeriod"</summary>
        public const string Base = "Api/Fiscal/{fiscalId}/FiscalPeriod";

        /// <summary>"{id}/RecalculatePrimo"</summary>
        public const string PutRecalculatePrimo = "{id}/RecalculatePrimo";

        /// <summary>"{id}/Data"</summary>
        public const string GetData = "{id}/Data";

        /// <summary>"DatesForBookkeeping"</summary>
        public const string GetDatesForBookkeeping = "DatesForBookkeeping";

        /// <summary>"Dates"</summary>
        public const string GetDates = "Dates";
    }
}