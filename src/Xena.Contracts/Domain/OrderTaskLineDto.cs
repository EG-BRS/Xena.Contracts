using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class OrderTaskLedgerDto : EntityDto
    {
        public string Description { get; set; }
    }
    public class OrderTaskLineDto : EntityDto
    {
        public int? FiscalDateDays { get; set; }
        public long? CostTypeId { get; set; }
        public string OrderTaskLineType { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public decimal Quantity { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public long? ArticleId { get; set; }
        public long? ActivityTypeId { get; set; }
        public long? ArticleVariantId { get; set; }
        public long? UnitId { get; set; }
        public long? LocationId { get; set; }
        public long? OrderTaskId { get; set; }
        public long? ResourceId { get; set; }
        public long? ArticleGroupId { get; set; }
        //Convinience properties
        public bool CopyFromLastLine { get; set; }
        [ReadOnly(true)]
        public long? CreatedById { get; set; }
        [ReadOnly(true)]
        public long? ResponsibleId { get; set; }
        [ReadOnly(true)]
        public string CreatedByName { get; set; }
        [ReadOnly(true)]
        public string ResponsibleName { get; set; }
        [ReadOnly(true)]
        public string ResourceName { get; set; }
        [ReadOnly(true)]
        public string CostTypeDescription { get; set; }
        [ReadOnly(true)]
        public int? CostTypeIndex { get; set; }
        [ReadOnly(true)]
        public string ArticleNumber { get; set; }
        [ReadOnly(true)]
        public string ArticleGroupDescription { get; set; }
        [ReadOnly(true)]
        public string ArticleDescription { get; set; }
        [ReadOnly(true)]
        public bool ArticleHasInventoryManagement { get; set; }
        [ReadOnly(true)]
        public bool ArticleHasVariants { get; set; }
        [ReadOnly(true)]
        public string ArticleVariantAbbreviation { get; set; }
        [ReadOnly(true)]
        public string ActivityTypeAbbreviation { get; set; }
        [ReadOnly(true)]
        public string ActivityTypeDescription { get; set; }
        public bool ActivityTypeIsBillable { get; set; }
        public bool ActivityTypeIsAtWork { get; set; }
        public bool ActivityTypeIsPaid { get; set; }
        [ReadOnly(true)]
        public string UnitAbbreviation { get; set; }
        [ReadOnly(true)]
        public string LocationAbbreviation { get; set; }
        [ReadOnly(true)]
        public string OrderTaskDescription { get; set; }
        [ReadOnly(true)]
        public int? OrderTaskIndex { get; set; }
        [ReadOnly(true)]
        public int? OrderNumber { get; set; }
        [ReadOnly(true)]
        public int DocumentCount { get; set; }
        private string _orderTaskLineTypeTranslated = null;
        [ReadOnly(true)]
        public string OrderTaskLineTypeTranslated
        {
            get
            {
                return _orderTaskLineTypeTranslated ?? (string.IsNullOrEmpty(OrderTaskLineType)
                           ? string.Empty
                           : OrderTaskLineType.GetLocalizedConstant());
            }
            set { _orderTaskLineTypeTranslated = value; }
        }
        private string _orderTaskAbbreviation = null;
        [ReadOnly(true)]
        public string OrderTaskAbbreviation
        {
            get
            {
                return _orderTaskAbbreviation ??
                       (OrderTaskId.HasValue ? $"{OrderNumber}-{OrderTaskIndex}" : string.Empty);
            }
            set { _orderTaskAbbreviation = value; }
        }

        private string _fiscalDateDaysFriendly = null;
        [ReadOnly(true)]
        public string FiscalDateDaysFriendly
        {
            get { return _fiscalDateDaysFriendly ?? FiscalDateDays.FriendlyString(); }
            set { _fiscalDateDaysFriendly = value; }
        }

        private string _articleAbbreviation = null;
        [ReadOnly(true)]
        public string ArticleAbbreviation
        {
            get
            {
                return _articleAbbreviation ?? (string.IsNullOrEmpty(ArticleVariantAbbreviation)
                           ? ArticleNumber
                           : $"{ArticleNumber}-{ArticleVariantAbbreviation}");
            }
            set { _articleAbbreviation = value; }
        }
        public string DepartmentDescription { get; set; }
        public string PurposeDescription { get; set; }
        public string BearerDescription { get; set; }

        public long? DepartmentId { get; set; }
        public long? BearerId { get; set; }
        public long? PurposeId { get; set; }
        public long? OrderTaskLedgerId { get; set; }
        public string Note { get; set; }
    }
}