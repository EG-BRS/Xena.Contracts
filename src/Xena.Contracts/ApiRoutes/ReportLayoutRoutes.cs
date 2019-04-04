namespace Xena.Contracts.ApiRoutes
{
    public class ReportLayoutRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/ReportLayout"</summary>
        public const string Base = "Fiscal/{fiscalId}/ReportLayout";

        /// <summary>"{group}"</summary>
        public const string GetByGroup = "Group/{group}";

        /// <summary>"{id}/XSL"</summary>
        public const string PutXSL = "{id}/XSL";

        /// <summary>"OrderReport"</summary>
        public const string GetOrderReport = "OrderReport";

        /// <summary>"Modules"</summary>
        public const string GetModules = "Modules";

        /// <summary>"DefaultReminderSteps"</summary>
        public const string PostDefaultReminderSteps = "DefaultReminderSteps";
    }
}