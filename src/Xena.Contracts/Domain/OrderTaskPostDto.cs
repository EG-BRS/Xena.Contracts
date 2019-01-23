using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class OrderTaskPostDto : TransactionalDto
    {
        private DimensionsDto _dimensions;
        public long? OrderLineId { get; set; }
        
        //Convinience properties
        [ReadOnly(true)]
        public int FiscalDateDays { get; set; }
        [ReadOnly(true)]
        public string Type { get; set; }
        public long OrderTaskId { get; set; }
        [ReadOnly(true)]
        public long OrderTaskIndex { get; set; }
        [ReadOnly(true)]
        public string OrderTaskDescription { get; set; }
        [ReadOnly(true)]
        public long? OrderTaskStatusId { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        [ReadOnly(true)]
        public int OrderNumber { get; set; }
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
        public decimal? Total { get; set; }
        [ReadOnly(true)]
        public decimal? OrderLineWeight { get; set; }
        [ReadOnly(true)]
        public long? ArticleId { get; set; }
        [ReadOnly(true)]
        public long? ResourceId { get; set; }
        [ReadOnly(true)]
        public string ResourceName { get; set; }
        public long? ActivityTypeId { get; set; }
        public string ActivityTypeType { get; set; }
        [ReadOnly(true)]
        public long OrderId { get; set; }
        [ReadOnly(true)]
        public string OrderContextType { get; set; }
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
        public long? OrderLineUnitId { get; set; }
        public string OrderLineUnitAbbreviation { get; set; }
        public long? OrderLineArticleId { get; set; }
        public long? OrderLineArticleGroupId { get; set; }
        public string OrderLineArticleGroupDescription { get; set; }
        public string OrderLineArticleNumber { get; set; }
        public decimal? OrderLineQuantity { get; set; }

        private string _orderTaskAbbreviation = null;
        [ReadOnly(true)]
        public string OrderTaskAbbreviation
        {
            get { return _orderTaskAbbreviation ?? $"{OrderNumber}-{OrderTaskIndex}"; }
            set { _orderTaskAbbreviation = value; }
        }

        [ReadOnly(true)]
        public int DocumentCount { get; set; }
        [ReadOnly(true)]
        public long? ResponsibleId { get; set; }
        [ReadOnly(true)]
        public string ResponsibleName { get; set; }
        private string _fiscalDateDaysFriendly = null;
        [ReadOnly(true)]
        public string FiscalDateDaysFriendly
        {
            get { return _fiscalDateDaysFriendly ?? FiscalDateDays.ToDate().ToString("d"); }
            set { _fiscalDateDaysFriendly = value; }
        }

        public string DepartmentDescription { get; set; }
        public string PurposeDescription { get; set; }
        public string BearerDescription { get; set; }

        public DimensionsDto Dimensions
        {
            get => _dimensions ?? (_dimensions = new DimensionsDto());
            set => _dimensions = value;
        }
    }
}
