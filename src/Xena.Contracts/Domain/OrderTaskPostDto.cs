using System;
using System.Collections.Generic;
using System.Text;

namespace Xena.Contracts.Domain
{
    public class OrderTaskPostDto : TransactionalDto
    {
        public int FiscalDateDays { get; set; }
        public string Type { get; set; }
        public long OrderTaskId { get; set; }
        public long OrderTaskIndex { get; set; }
        public string OrderTaskDescription { get; set; }
        public string Description { get; set; }
        public int OrderNumber { get; set; }
        public long? CostTypeId { get; set; }
        public long? ProjectId { get; set; }
        public string CostTypeDescription { get; set; }
        public decimal Quantity { get; set; }
        public decimal CostEach { get; set; }
        public decimal Total { get; set; }
        public decimal? SalesPrice { get; set; }
        public long? ArticleId { get; set; }
        public long? ResourceId { get; set; }
        public string ResourceName { get; set; }
        public string ArticleNumber { get; set; }
        public string ArticleDescription { get; set; }
        public string OrderTaskAbbreviation => $"{OrderNumber}-{OrderTaskIndex}";
        public long? OrderLineId { get; set; }
        public long OrderId { get; set; }
        public bool IsApproved { get; set; }
        public long? ActivityTypeId { get; set; }
        public string ActivityTypeType { get; set; }
    }
}
