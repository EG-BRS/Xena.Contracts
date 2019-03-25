namespace Xena.Contracts.ApiRoutes
{
    public class AppointmentRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/Appointment"</summary>
        public const string Base = "Fiscal/{fiscalId}/Appointment";

        /// <summary>"~/Fiscal/{fiscalId}/Resource/{id}/Appointment"</summary>
        public const string GetByResourceList = "~/Fiscal/{fiscalId}/Resource/{id}/Appointment";

        /// <summary>"~/Fiscal/{fiscalId}/Team/{id}/Appointment"</summary>
        public const string GetByTeamList = "~/Fiscal/{fiscalId}/Team/{id}/Appointment";

        /// <summary>"~/Fiscal/{fiscalId}/Team/{id}/Appointment"</summary>
        public const string PostByTeam = "~/Fiscal/{fiscalId}/Team/{id}/Appointment";

        /// <summary>"~/Fiscal/{fiscalId}/Order/{id}/Appointment"</summary>
        public const string GetByOrderList = "~/Fiscal/{fiscalId}/Order/{id}/Appointment";

        /// <summary>"~/Fiscal/{fiscalId}/OrderTask/{id}/Appointment"</summary>
        public const string GetByOrderTaskList = "~/Fiscal/{fiscalId}/OrderTask/{id}/Appointment";

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