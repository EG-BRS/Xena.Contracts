namespace Xena.Contracts.Domain
{
    public class AppointmentDto : EntityDto
    {
        public int? StartDateDays { get; set; }
        public int? StartTimeMinutes { get; set; }
        public int? StartTimeHours { get; set; }
        public int? EndDateDays { get; set; }
        public int? EndTimeMinutes { get; set; }
        public int? EndTimeHours { get; set; }
        public int? DeadlineDateDays { get; set; }
        public int? DeadlineTimeMinutes { get; set; }
        public int? DeadlineTimeHours { get; set; }
        public long? ActivityTypeId { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public long? ResourceId { get; set; }
        public long? TeamId { get; set; }
        public long? OrderTaskId { get; set; }
        public int DurationHours { get; set; }
        public int DurationMinutes { get; set; }
        public bool IsFullDay { get; set; }
        public bool ReminderSet { get; set; }
        public int? ReminderTime { get; set; }
        public AddressDto Address { get; set; }
        public AddressDto DeliveryAddress { get; set; }        
        public string ActivityTypeDescription { get; set; }
        public bool? ActivityTypeIsBillable { get; set; }
        public bool? ActivityTypeIsAtWork { get; set; }
        public bool? ActivityTypeIsPaid { get; set; }
        public string OrderStatusColor { get; set; }
        public string ResourceName { get; set; }
        public int? OrderNumber { get; set; }
        public long? OrderId { get; set; }
        public string OrderTaskDescription { get; set; }
        public int? OrderTaskIndex { get; set; }
        public string StartFriendly { get; set; }
        public string StartNoDateFriendly { get; set; }
        public string EndTimeFriendly { get; set; }
        public string StartTimeFriendly { get; set; }
        public string EndFriendly { get; set; }
        public string OrderTaskAbbreviation { get; set; }
        public string StartEndFriendlyDescription { get; set; }
        public string DurationFriendly { get; set; }
        public string TeamName { get;  set; }
        public string DeadlineTimeFriendly { get; set; }
    }
}