using System;
using System.Collections.Generic;
using System.Text;

namespace Xena.Contracts.Domain
{
    public class OrderTaskLineDto
    {
        public int Version { get; set; }
        public bool IsDeactivated { get; set; }
        public int FiscalSetupId { get; set; }
        public string CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int FiscalDateDays { get; set; }
        public int CostTypeId { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public double Quantity { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public int ArticleId { get; set; }
        public int ActivityTypeId { get; set; }
        public int ArticleVariantId { get; set; }
        public int UnitId { get; set; }
        public int LocationId { get; set; }
        public int OrderTaskId { get; set; }
        public int ResourceId { get; set; }
        public int ResponsibleId { get; set; }
        public string ResponsibleName { get; set; }
        public string ResourceName { get; set; }
        public string CostTypeDescription { get; set; }
        public string ArticleNumber { get; set; }
        public string ArticleDescription { get; set; }
        public bool ArticleHasInventoryManagement { get; set; }
        public bool ArticleHasVariants { get; set; }
        public string ArticleVariantAbbreviation { get; set; }
        public string ActivityTypeAbbreviation { get; set; }
        public string ActivityTypeDescription { get; set; }
        public string UnitAbbreviation { get; set; }
        public string LocationAbbreviation { get; set; }
        public string OrderTaskDescription { get; set; }
        public int OrderTaskIndex { get; set; }
        public int OrderNumber { get; set; }
        public int DocumentCount { get; set; }
        public string OrderTaskAbbreviation { get; set; }
        public string FiscalDateDaysFriendly { get; set; }
        public string ArticleAbbreviation { get; set; }
        public int Id { get; set; }
    }
}
