namespace Xena.Contracts.ApiRoutes
{
    public class ActivityRoutes : BaseRoutes
    {
        /// <summary>"Api/Fiscal/{fiscalId}/Activity"</summary>
        public const string Base = "Api/Fiscal/{fiscalId}/Activity";

        /// <summary>"~/Api/Fiscal/{fiscalId}/Resource/{id}/Activity"</summary>
        public const string GetByResourceList = "~/Api/Fiscal/{fiscalId}/Resource/{id}/Activity";
        /// <summary>"~/Api/Fiscal/{fiscalId}/Order/{id}/Activity"</summary>
        public const string GetByOrderList = "~/Api/Fiscal/{fiscalId}/Order/{id}/Activity";
        /// <summary>"~/Api/Fiscal/{fiscalId}/ActivityType/{id}/Activity"</summary>
        public const string GetByActivityTypeList = "~/Api/Fiscal/{fiscalId}/ActivityType/{id}/Activity";

        /// <summary>"GroupedFiltered"</summary>
        public const string GetGroupedFilteredList = "GroupedFiltered";
        /// <summary>"FilteredList"</summary>
        public const string GetFilteredList = "FilteredList";

        /// <summary>"Approve"</summary>
        public const string PutApprove = "Approve";

        /// <summary>"FromAppointment/{appointmentId}"</summary>
        public const string PostFromAppointment = "FromAppointment/{appointmentId}";

        /// <summary>"FromActivityType/{activtyTypeId}"</summary>
        public const string PostFromActivtyType = "FromActivityType/{activtyTypeId}";

        /// <summary>"Current"</summary>
        public const string GetCurrent = "Current";

    }
}