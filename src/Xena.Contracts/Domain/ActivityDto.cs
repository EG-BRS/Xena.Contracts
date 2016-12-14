

namespace Xena.Contracts.Domain
{
    public class ActivityDto : EntityDto
    {
        public long ResourceId { get; set; }
        public string ResourceName { get; set; }
        public int StartDateDays { get; set; }
        public int? StartTimeMinutes { get; set; }
        public int? StartTimeHours { get; set; }
        public int? DurationHours { get; set; }
        public int? DurationMinutes { get; set; }
        public long? OrderId { get; set; }
        public int? OrderNumber { get; set; }
        public long? ActivityTypeId { get; set; }
        public string ActivityTypeDescription { get; set; }
        public string ActivityTypeColor { get; set; }

        public decimal? BillableQuantity { get; set; }

        public string StartFriendly { get; set; }

        public string StartTimeFriendly { get; set; }
    }
}