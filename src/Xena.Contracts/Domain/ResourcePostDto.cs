using System;

namespace Xena.Contracts.Domain
{
    public class ResourcePostDto : EntityDto
    {
        public long? OrderLineId { get; set; }
        public string Type { get; set; }
        public long? OrderTaskId { get; set; }
        public long? OrderTaskIndex { get; set; }
        public string OrderTaskDescription { get; set; }
        public string Description { get; set; }
        public int? OrderNumber { get; set; }
        public string OrderName { get; set; }
        public long? CostTypeId { get; set; }
        public long? ProjectId { get; set; }
        public long? UnitId { get; set; }
        public string UnitAbbreviation { get; set; }
        public string CostTypeDescription { get; set; }
        public decimal? Quantity { get; set; }
        public decimal CostEach { get; set; }
        public decimal Total { get; set; }
        public decimal? OrderLineWeight { get; set; }
        public long? ArticleId { get; set; }
        public long ResourceId { get; set; }
        public string ResourceName { get; set; }
        public long? ActivityTypeId { get; set; }
        public long? OrderId { get; set; }
        public bool IsApproved { get; set; }
        public string ArticleNumber { get; set; }
        public string ArticleDescription { get; set; }
        public string ActivityTypeDescription { get; set; }
        public string ActivityTypeAbbreviation { get; set; }
        public string ActivityTypeType { get; protected set; }
        public bool? ActivityTypeIsBillable { get; set; }
        public bool? ActivityTypeIsAtWork { get; set; }
        public bool? ActivityTypeIsPaid { get; set; }
        public long? OrderLineUnitId { get; set; }
        public string OrderLineUnitAbbreviation { get; set; }
        public long? OrderLineArticleId { get; set; }
        public long? OrderLineArticleGroupId { get; set; }
        public string OrderLineArticleGroupDescription { get; set; }
        public string OrderLineArticleNumber { get; set; }
        public decimal? OrderLineQuantity { get; set; }
        public string OrderTaskAbbreviation { get; set; }
        public long? ResponsibleId { get; set; }
        public string ResponsibleName { get; set; }
        public int StartDateDays { get; set; }
        public int? StartTimeMinutes { get; set; }
        public int? StartTimeHours { get; set; }
        public int? DurationHours { get; set; }
        public int? DurationMinutes { get; set; }
        public decimal? Duration { get; set; }
        public string StartFriendly { get; set; }
        public string StartTimeFriendly { get; set; }
        public int? EndTimeHours { get; set; }
        public int? EndTimeMinutes { get; set; }
        public string EndTimeFriendly { get; set; }
    }
}
