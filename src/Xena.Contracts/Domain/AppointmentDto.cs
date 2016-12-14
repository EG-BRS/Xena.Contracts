using System;


namespace Xena.Contracts.Domain
{
    public class AppointmentDto : EntityDto
    {
        public int StartDateDays { get; set; }
        public int? StartTimeMinutes { get; set; }
        public int? StartTimeHours { get; set; }
        public int EndDateDays { get; set; }
        public int? EndTimeMinutes { get; set; }
        public int? EndTimeHours { get; set; }
        public long? ActivityTypeId { get; set; }
        public string ActivityTypeDescription { get; set; }
        public string Description { get; set; }
        public long ResourceId { get; set; }
        public string ResourceName { get; set; }
        public int? OrderNumber { get; set; }
        public long? OrderId { get; set; }
        public string StartFriendly { get; set; }
        public string StartNoDateFriendly { get; set; }

        public string EndFriendly { get; set; }

        public string StartEndFriendlyDescription { get; set; }

        public int DurationHours { get; set; }
        public int DurationMinutes { get; set; }

        public string DurationFriendly
        { get; set; }

        public string OrderStatusColor { get; set; }
    }
}