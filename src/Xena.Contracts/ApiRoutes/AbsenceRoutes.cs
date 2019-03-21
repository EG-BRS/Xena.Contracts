namespace Xena.Contracts.ApiRoutes
{
    public class AbsenceRoutes : BaseRoutes
    {
        /// <summary>"Api/Fiscal/{fiscalId}/Absence"</summary>
        public const string Base = "Api/Fiscal/{fiscalId}/Absence";

        /// <summary>"~/Api/Fiscal/{fiscalId}/Resource/{id}/Absence"</summary>
        public const string GetByResourceList = "~/Api/Fiscal/{fiscalId}/Resource/{id}/Absence";

        /// <summary>"FilteredList"</summary>
        public const string GetFilteredList = "FilteredList";
    }
}