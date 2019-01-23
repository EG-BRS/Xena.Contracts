using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class AppointmentDto : EntityDto
    {
        public AppointmentDto()
        {
        }
        public AppointmentDto(string resourceName)
        {
            ResourceName = resourceName;
        }

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
        [Required]
        [StringLength(255)]
        public string Description { get; set; }
        public string Details { get; set; }
        public long? ResourceId { get; set; }
        public long? TeamId { get; set; }
        public long? OrderTaskId { get; set; }
        public long? OrderStatusId { get; set; }
        public int? DurationHours { get; set; }
        public int? DurationMinutes { get; set; }
        public bool ReminderSet { get; set; }
        public int? ReminderTime { get; set; }
        [ReadOnly(true)]
        public AddressDto Address { get; set; }
        [ReadOnly(true)]
        public AddressDto DeliveryAddress { get; set; }

        //Convinience properties
        [ReadOnly(true)]
        public string ActivityTypeDescription { get; set; }
        [ReadOnly(true)]
        public string ActivityTypeColour { get; set; }
        [ReadOnly(true)]
        public bool? ActivityTypeIsBillable { get; set; }
        [ReadOnly(true)]
        public bool? ActivityTypeIsAtWork { get; set; }
        [ReadOnly(true)]
        public bool? ActivityTypeIsPaid { get; set; }
        [ReadOnly(true)]
        public string OrderStatusColor { get; set; }
        [ReadOnly(true)]
        public string OrderStatusName { get; set; }
        [ReadOnly(true)]
        public string ResourceName { get; set; }
        [ReadOnly(true)]
        public int? OrderNumber { get; set; }
        [ReadOnly(true)]
        public long? OrderId { get; set; }
        [ReadOnly(true)]
        public string OrderTaskDescription { get; set; }
        [ReadOnly(true)]
        public long? OrderTaskStatusId { get; set; }
        [ReadOnly(true)]
        public string OrderTaskStatusColor { get; set; }
        [ReadOnly(true)]
        public string OrderTaskStatusName { get; set; }
        [ReadOnly(true)]
        public int? OrderTaskIndex { get; set; }

        [ReadOnly(true)]
        public string TeamName { get; set; }


        private string _startFriendly;
        [ReadOnly(true)]
        public string StartFriendly
        {
            get
            {
                return _startFriendly ?? (StartDateDays.HasValue
                    ? StartTimeHours.HasValue
                        ? $"{StartDateDays.Value.ToDate().ToString("d")} - {StartTimeHours.Value:D2}:{StartTimeMinutes ?? 0:D2}"
                        : $"{StartDateDays.Value.ToDate().ToString("d")}"
                    : string.Empty);
            }
            set { _startFriendly = value; }
        }

        private string _startNoDateFriendly;
        [ReadOnly(true)]
        public string StartNoDateFriendly
        {
            get
            {
                return _startNoDateFriendly ?? (StartTimeHours.HasValue
                    ? $"{StartTimeHours.Value:D2}:{(StartTimeMinutes ?? 0):D2}"
                    : StartFriendly);
            }
            set { _startNoDateFriendly = value; }
        }

        private string _endTimeFriendly;
        [ReadOnly(true)]
        public string EndTimeFriendly
        {
            get
            {
                return _endTimeFriendly ?? (EndTimeHours.HasValue
                    ? $"{EndTimeHours.Value:D2}:{EndTimeMinutes ?? 0:D2}"
                    : string.Empty);
            }
            set { _endTimeFriendly = value; }
        }

        private string _startTimeFriendly;
        [ReadOnly(true)]
        public string StartTimeFriendly
        {
            get
            {
                return StartTimeHours.HasValue
                    ? $"{StartTimeHours.Value:D2}:{StartTimeMinutes ?? 0:D2}"
                    : string.Empty;
            }
        }

        private string _endFriendly;
        [ReadOnly(true)]
        public string EndFriendly
        {
            get
            {
                return _endFriendly ?? (EndDateDays.HasValue
                    ? EndTimeHours.HasValue
                        ? $"{EndDateDays.Value.ToDate().ToString("d")} - {EndTimeHours.Value:D2}:{(EndTimeMinutes ?? 0):D2}"
                        : $"{EndDateDays.Value.ToDate().ToString("d")}"
                    : string.Empty);
            }
            set { _endFriendly = value; }
        }

        private int? _startValueMinutes;
        [ReadOnly(true)]
        public int? StartValueInMinutes
        {
            get
            {
                return _startValueMinutes ?? (StartDateDays * 1440 + StartTimeHours.GetValueOrDefault() * 60 + StartTimeMinutes.GetValueOrDefault());
            }
            set { _startValueMinutes = value; }
        }

        private int? _endValueMinutes;
        [ReadOnly(true)]
        public int? EndValueInMinutes
        {
            get
            {
                return _endValueMinutes ?? (EndDateDays * 1440 + EndTimeHours.GetValueOrDefault() * 60 + EndTimeMinutes.GetValueOrDefault());
            }
            set { _endValueMinutes = value; }
        }

        private string _orderTaskAbbreviation;
        [ReadOnly(true)]
        public string OrderTaskAbbreviation
        {
            get
            {
                return _orderTaskAbbreviation ?? (OrderTaskId.HasValue ? $"{OrderNumber}-{OrderTaskId}" : string.Empty);
            }
            set { _orderTaskAbbreviation = value; }
        }

        private string _startEndFriendlyDescription;
        [ReadOnly(true)]
        public string StartEndFriendlyDescription
        {
            get
            {
                if (!string.IsNullOrEmpty(_startEndFriendlyDescription))
                    return _startEndFriendlyDescription;

                if (!StartDateDays.HasValue || !EndDateDays.HasValue)
                    return string.Empty;
                if (StartDateDays.Value != EndDateDays)
                {
                    return StartTimeHours.HasValue && EndTimeHours.HasValue
                        ? $"{StartDateDays.Value.ToDate().ToString("d")}/{StartTimeHours.Value:D2}:{(StartTimeMinutes ?? 0):D2} - {EndDateDays.Value.ToDate().ToString("d")}/{EndTimeHours.Value:D2}:{(EndTimeMinutes ?? 0):D2} "
                        : $"{StartDateDays.Value.ToDate().ToString("d")} - {EndDateDays.Value.ToDate().ToString("d")}";
                }
                return StartTimeHours.HasValue && EndTimeHours.HasValue
                    ? $"{StartTimeHours.Value:D2}:{(StartTimeMinutes ?? 0):D2} - {EndTimeHours.Value:D2}:{(EndTimeMinutes ?? 0):D2}"
                    : $"{StartDateDays.Value.ToDate().ToString("d")} - {EndDateDays.Value.ToDate().ToString("d")}";
            }
            set { _startEndFriendlyDescription = value; }
        }

        private string _durationFriendly;
        [ReadOnly(true)]
        public string DurationFriendly
        {
            get { return _durationFriendly ?? $"({DurationHours:D2}:{DurationMinutes:D2})"; }
            set { _durationFriendly = value; }
        }


        private string _deadlineTimeFriendly;
        [ReadOnly(true)]
        public string DeadlineTimeFriendly
        {
            get
            {
                return _deadlineTimeFriendly ?? (DeadlineTimeHours.HasValue
                    ? $"{DeadlineTimeHours.Value:D2}:{DeadlineTimeMinutes ?? 0:D2}"
                    : string.Empty);
            }
            set { _deadlineTimeFriendly = value; }
        }
    }
}