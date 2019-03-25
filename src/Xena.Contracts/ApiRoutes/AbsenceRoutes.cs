namespace Xena.Contracts.ApiRoutes
{
    public class AbsenceRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/Absence"</summary>
        public const string Base = "Fiscal/{fiscalId}/Absence";

        /// <summary>"~/Fiscal/{fiscalId}/Resource/{id}/Absence"</summary>
        public const string GetByResourceList = "~/Fiscal/{fiscalId}/Resource/{id}/Absence";

        /// <summary>"FilteredList"</summary>
        public const string GetFilteredList = "FilteredList";
    }
}