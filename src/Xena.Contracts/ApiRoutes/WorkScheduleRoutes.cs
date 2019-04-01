namespace Xena.Contracts.ApiRoutes
{
    public class WorkScheduleRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/WorkSchedule"</summary>
        public const string Base = "Fiscal/{fiscalId}/WorkSchedule";

        /// <summary>"FilteredList"</summary>
        public const string GetFilteredList = "FilteredList";

        /// <summary>"{id}/SetAsCompanyDefault"</summary>
        public const string PutSetAsCompanyDefault = "{id}/SetAsCompanyDefault";
    }
}