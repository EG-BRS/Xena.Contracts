namespace Xena.Contracts.ApiRoutes
{
    public class ActivityRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/Activity"</summary>
        public const string Base = "Fiscal/{fiscalId}/Activity";

        /// <summary>"~/Fiscal/{fiscalId}/Resource/{id}/Activity"</summary>
        public const string GetByResourceList = "~/Fiscal/{fiscalId}/Resource/{id}/Activity";
        /// <summary>"~/Fiscal/{fiscalId}/Order/{id}/Activity"</summary>
        public const string GetByOrderList = "~/Fiscal/{fiscalId}/Order/{id}/Activity";
        /// <summary>"~/Fiscal/{fiscalId}/ActivityType/{id}/Activity"</summary>
        public const string GetByActivityTypeList = "~/Fiscal/{fiscalId}/ActivityType/{id}/Activity";

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