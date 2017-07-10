using System;
using System.Collections.Generic;
using System.Text;

namespace Xena.Contracts.Domain
{
    public class OrderTaskPostGroupedData
    {
        public int ArticleId { get; set; }
        public int UnitId { get; set; }
        public string UnitAbbreviation { get; set; }
        public string ArticleNumber { get; set; }
        public string Description { get; set; }
        public int TotalQuantity { get; set; }
        public int[] OrderTaskPostIds { get; set; }
        public int TotalCosts { get; set; }
        public int OrderTaskId { get; set; }
        public string OrderTaskAbbreviation { get; set; }
        public string OrderTaskDescription { get; set; }
        public int OrderLineId { get; set; }
        public int OrderLineUnitId { get; set; }
        public string OrderLineUnitAbbreviation { get; set; }
        public int OrderLineArticleId { get; set; }
        public int OrderLineArticleGroupId { get; set; }
        public string OrderLineArticleGroupDescription { get; set; }
        public string OrderLineArticleNumber { get; set; }
        public int OrderLineQuantity { get; set; }
    }
}
