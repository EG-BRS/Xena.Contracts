using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class ActivityDto : EntityDto
    {
        private DimensionsDto _dimensions;

        [Required]
        public long ResourceId { get; set; }
        [Required]
        public int StartDateDays { get; set; }
        public int? StartTimeMinutes { get; set; }
        public int? StartTimeHours { get; set; }
        public int? DurationHours { get; set; }
        public int? DurationMinutes { get; set; }
        public long? OrderTaskId { get; set; }
        public long? ActivityTypeId { get; set; }
        public AddressDto Address { get; set; }
        public AddressDto DeliveryAddress { get; set; }

        //Convinience properties
        [ReadOnly(true)]
        public long? OrderStatusId { get; set; }
        [ReadOnly(true)]
        public string OrderStatusName { get; set; }
        [ReadOnly(true)]
        public string OrderStatusColor { get; set; }
        [ReadOnly(true)]
        public long? OrderTaskStatusId { get; set; }
        [ReadOnly(true)]
        public string OrderTaskStatusName { get; set; }
        [ReadOnly(true)]
        public string OrderTaskStatusColor { get; set; }
        [ReadOnly(true)]
        public long? OrderLineId { get; set; }
        [ReadOnly(true)]
        public decimal? OrderLineWeight { get; set; }
        [ReadOnly(true)]
        public long? OrderId { get; set; }
        [ReadOnly(true)]
        public string ResourceName { get; set; }
        [ReadOnly(true)]
        public string OrderTaskDescription { get; set; }
        [ReadOnly(true)]
        public int? OrderTaskIndex { get; set; }
        [ReadOnly(true)]
        public int? OrderNumber { get; set; }
        [ReadOnly(true)]
        public string ActivityTypeDescription { get; set; }
        [ReadOnly(true)]
        public string ActivityTypeColor { get; set; }

        private string _orderTaskAbbreviation;
        [ReadOnly(true)]
        public string OrderTaskAbbreviation
        {
            get { return _orderTaskAbbreviation ?? (OrderTaskId.HasValue ? $"{OrderNumber}-{OrderTaskIndex}" : string.Empty); }
            set { _orderTaskAbbreviation = value; }
        }

        private string _startFriendly;
        [ReadOnly(true)]
        public string StartFriendly
        {
            get
            {
                return _startFriendly ?? (StartTimeHours.HasValue
                    ? $"{StartDateDays.ToDate().ToString("d")} - {StartTimeHours.Value:D2}:{StartTimeMinutes ?? 0:D2}"
                    : $"{StartDateDays.ToDate().ToString("d")}");
            }
            set { _startFriendly = value; }
        }

        private string _startTimeFriendly;
        [ReadOnly(true)]
        public string StartTimeFriendly
        {
            get { return _startTimeFriendly ?? (StartTimeHours.HasValue ? $"{StartTimeHours.Value:D2}:{StartTimeMinutes ?? 0:D2}" : "-"); }
            set { _startTimeFriendly = value; }
        }

        private string _durationTimeFriendly;
        [ReadOnly(true)]
        public string DurationTimeFriendly
        {
            get { return _durationTimeFriendly ?? (DurationHours.HasValue ? $"{DurationHours.Value:D2}:{DurationMinutes ?? 0:D2}" : "-" ); }
            set { _durationTimeFriendly = value; }
        }

        [ReadOnly(true)]
        public bool IsApproved { get; set; }
        [ReadOnly(true)]
        public bool? ActivityTypeIsBillable { get; set; }
        [ReadOnly(true)]
        public bool? ActivityTypeIsAtWork { get; set; }
        [ReadOnly(true)]
        public bool? ActivityTypeIsPaid { get; set; }
        [ReadOnly(true)]
        public string ActivityTypeType { get; set; }
        [ReadOnly(true)]
        public decimal? CostEach { get; set; }
        [ReadOnly(true)]
        public decimal? Total { get; set; }

        public string DepartmentDescription { get; set; }
        public string PurposeDescription { get; set; }
        public string BearerDescription { get; set; }
        public string Note { get; set; }

        public DimensionsDto Dimensions
        {
            get => _dimensions ?? (_dimensions = new DimensionsDto());
            set => _dimensions = value;
        }
    }
}