

namespace Xena.Contracts.Domain
{
    public class ActivityDto : EntityDto
    {
        public long ResourceId { get; set; }
        public int StartDateDays { get; set; }
        public int? StartTimeMinutes { get; set; }
        public int? StartTimeHours { get; set; }
        public int? DurationHours { get; set; }
        public int? DurationMinutes { get; set; }
        public long? OrderTaskId { get; set; }
        public long? OrderLineId { get; set; }
        public long? ActivityTypeId { get; set; }
        public decimal? BillableQuantity { get; set; }
        //Convinience properties
        public long? OrderId { get; set; }
        public string ResourceName { get; set; }
        public string OrderTaskDescription { get; set; }
        public int? OrderTaskIndex { get; set; }
        public int? OrderNumber { get; set; }
        public string ActivityTypeDescription { get;  set; }
        public string ActivityTypeColor { get;  set; }
        public string OrderTaskAbbreviation { get; set; }
        public string StartFriendly { get; set; }
        public string StartTimeFriendly { get; set; }
        public string DurationTimeFriendly { get; set; }
        public bool IsApproved { get; set; }
        public bool? ActivityTypeIsBillable { get; set; }
        public bool? ActivityTypeIsAtWork { get; set; }
        public bool? ActivityTypeIsPaid { get; set; }
        public string ActivityTypeType { get; set; }
        public decimal? CostEach { get; set; }
        public decimal? Total { get; set; }
        public decimal? SalesPrice { get; set; }
        public string Note { get; set; }
    }
}