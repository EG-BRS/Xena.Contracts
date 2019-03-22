namespace Xena.Contracts.ApiRoutes
{
    public class AppointmentRoutes : BaseRoutes
    {
        /// <summary>"Api/Fiscal/{fiscalId}/Appointment"</summary>
        public const string Base = "Api/Fiscal/{fiscalId}/Appointment";

        /// <summary>"~/Api/Fiscal/{fiscalId}/Resource/{id}/Appointment"</summary>
        public const string GetByResourceList = "~/Api/Fiscal/{fiscalId}/Resource/{id}/Appointment";

        /// <summary>"~/Api/Fiscal/{fiscalId}/Team/{id}/Appointment"</summary>
        public const string GetByTeamList = "~/Api/Fiscal/{fiscalId}/Team/{id}/Appointment";

        /// <summary>"~/Api/Fiscal/{fiscalId}/Team/{id}/Appointment"</summary>
        public const string PostByTeam = "~/Api/Fiscal/{fiscalId}/Team/{id}/Appointment";

        /// <summary>"~/Api/Fiscal/{fiscalId}/Order/{id}/Appointment"</summary>
        public const string GetByOrderList = "~/Api/Fiscal/{fiscalId}/Order/{id}/Appointment";

        /// <summary>"~/Api/Fiscal/{fiscalId}/OrderTask/{id}/Appointment"</summary>
        public const string GetByOrderTaskList = "~/Api/Fiscal/{fiscalId}/OrderTask/{id}/Appointment";

        /// <summary>"FilteredList"</summary>
        public const string GetFilteredList = "FilteredList";

        /// <summary>"AppoinmentsForToday"</summary>
        public const string GetAppoinmentsForToday = "AppoinmentsForToday";
        /// <summary>"AppointmentsForMonthlyView"</summary>
        public const string GetAppointmentsForMonthlyView = "AppointmentsForMonthlyView";

        /// <summary>"NextAvailableTime/Resource"</summary>
        public const string GetNextAvailableTimeResource = "NextAvailableTime/Resource";

        /// <summary>"NextAvailableTime/Team"</summary>
        public const string GetNextAvailableTimeTeam = "NextAvailableTime/Team";
    }
}