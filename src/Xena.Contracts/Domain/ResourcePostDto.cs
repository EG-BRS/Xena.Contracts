using System;
using System.ComponentModel;
using Xena.Common.Constants;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class ResourcePostDto : TransactionalDto
    {
        public long? OrderLineId { get; set; }

        //Convinience properties
        [ReadOnly(true)]
        public AddressDto Address { get; set; }
        [ReadOnly(true)]
        public AddressDto DeliveryAddress { get; set; }
        [ReadOnly(true)]
        public string Type { get; set; }
        [ReadOnly(true)]
        public long? OrderTaskId { get; set; }
        [ReadOnly(true)]
        public long? OrderTaskIndex { get; set; }
        [ReadOnly(true)]
        public string OrderTaskDescription { get; set; }
        [ReadOnly(true)]
        public string Description { get; set; }
        [ReadOnly(true)]
        public int? OrderNumber { get; set; }
        [ReadOnly(true)]
        public string OrderName { get; set; }
        [ReadOnly(true)]
        public long? CostTypeId { get; set; }
        [ReadOnly(true)]
        public long? ProjectId { get; set; }
        [ReadOnly(true)]
        public long? UnitId { get; set; }
        [ReadOnly(true)]
        public string UnitAbbreviation { get; set; }
        [ReadOnly(true)]
        public string CostTypeDescription { get; set; }
        [ReadOnly(true)]
        public decimal? Quantity { get; set; }
        [ReadOnly(true)]
        public decimal CostEach { get; set; }
        [ReadOnly(true)]
        public decimal Total { get; set; }
        [ReadOnly(true)]
        public decimal? OrderLineWeight { get; set; }
        [ReadOnly(true)]
        public long? ArticleId { get; set; }
        [ReadOnly(true)]
        public long ResourceId { get; set; }
        [ReadOnly(true)]
        public string ResourceName { get; set; }
        [ReadOnly(true)]
        public long? ActivityTypeId { get; set; }
        [ReadOnly(true)]
        public long? OrderId { get; set; }
        [ReadOnly(true)]
        public bool IsApproved { get; set; }
        [ReadOnly(true)]
        public string ArticleNumber { get; set; }
        [ReadOnly(true)]
        public string ArticleDescription { get; set; }
        [ReadOnly(true)]
        public string ActivityTypeDescription { get; set; }
        [ReadOnly(true)]
        public string ActivityTypeAbbreviation { get; set; }
        [ReadOnly(true)]
        public string ActivityTypeType { get; set; }
        [ReadOnly(true)]
        public string Note { get; set; }

        [ReadOnly(true)]
        public bool? ActivityTypeIsBillable { get; set; }
        [ReadOnly(true)]
        public bool? ActivityTypeIsAtWork { get; set; }
        [ReadOnly(true)]
        public bool? ActivityTypeIsPaid { get; set; }

        [ReadOnly(true)]
        public long? OrderLineUnitId { get; set; }
        [ReadOnly(true)]
        public string OrderLineUnitAbbreviation { get; set; }
        [ReadOnly(true)]
        public long? OrderLineArticleId { get; set; }
        [ReadOnly(true)]
        public long? OrderLineArticleGroupId { get; set; }
        [ReadOnly(true)]
        public string OrderLineArticleGroupDescription { get; set; }
        [ReadOnly(true)]
        public string OrderLineArticleNumber { get; set; }
        [ReadOnly(true)]
        public decimal? OrderLineQuantity { get; set; }

        private string _orderTaskAbbreviation = null;
        [ReadOnly(true)]
        public string OrderTaskAbbreviation
        {
            get { return _orderTaskAbbreviation ?? $"{OrderNumber}-{OrderTaskIndex}"; }
            set { _orderTaskAbbreviation = value; }
        }

        [ReadOnly(true)]
        public long? ResponsibleId { get; set; }
        [ReadOnly(true)]
        public string ResponsibleName { get; set; }

        //Activity related
        [ReadOnly(true)]
        public int StartDateDays { get; set; }
        [ReadOnly(true)]
        public int? StartTimeMinutes { get; set; }
        [ReadOnly(true)]
        public int? StartTimeHours { get; set; }
        [ReadOnly(true)]
        public int? DurationHours { get; set; }
        [ReadOnly(true)]
        public int? DurationMinutes { get; set; }

        private decimal? _calculatedHours = null;
        [ReadOnly(true)]
        public decimal? CalculatedHours
        {
            get
            {
                return _calculatedHours ??
                       (ActivityTypeTypes.Hours.Equals(ActivityTypeType, StringComparison.OrdinalIgnoreCase)
                           ? DurationHours.HasValue ? DurationHours.Value + (DurationMinutes ?? 0) / 60m : Quantity
                           : null);
            }
            set { _calculatedHours = value; }
        }

        private decimal? _calculatedQuantity = null;
        [ReadOnly(true)]
        public decimal? CalculatedQuantity
        {
            get
            {
                return _calculatedQuantity ??
                       (!ActivityTypeTypes.Hours.Equals(ActivityTypeType, StringComparison.OrdinalIgnoreCase)
                           ? DurationHours.HasValue ? DurationHours.Value + (DurationMinutes ?? 0) / 60m : Quantity
                           : null);
            }
            set { _calculatedQuantity = value; }
        }

        private string _startFriendly = null;
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

        private string _startTimeFriendly = null;
        [ReadOnly(true)]
        public string StartTimeFriendly
        {
            get
            {
                return _startTimeFriendly ?? (StartTimeHours.HasValue
                           ? $"{StartTimeHours.Value:D2}:{StartTimeMinutes ?? 0:D2}"
                           : "-");
            }
            set { _startTimeFriendly = value; }
        }

        private int? _endTimeHours = null;
        [ReadOnly(true)]
        public int? EndTimeHours
        {
            get
            {
                return _endTimeHours ?? (StartTimeHours + DurationHours + (StartTimeMinutes + DurationMinutes) / 60);
            }
            set { _endTimeHours = value; }
        }

        private int? _endTimeMinutes = null;
        [ReadOnly(true)]
        public int? EndTimeMinutes
        {
            get { return _endTimeMinutes ?? ((StartTimeMinutes + DurationMinutes) % 60); }
            set { _endTimeMinutes = value; }
        }

        private string _endTimeFriendly = null;
        [ReadOnly(true)]
        public string EndTimeFriendly
        {
            get
            {
                return _endTimeFriendly ??
                       (EndTimeHours.HasValue ? $"{EndTimeHours.Value:D2}:{EndTimeMinutes ?? 0:D2}" : "-");
            }
            set { _endTimeFriendly = value; }
        }
    }
}