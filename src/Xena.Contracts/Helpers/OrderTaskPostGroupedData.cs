namespace Xena.Contracts.Helpers
{
    public class OrderTaskPostGroupedData
    {
        public bool IsApproved { get; set; }
        public long? ArticleId { get; set; }
        public long? UnitId { get; set; }
        public string UnitAbbreviation { get; set; }
        public string ArticleNumber { get; set; }
        public string Description { get; set; }
        public decimal TotalQuantity { get; set; }
        public long[] OrderTaskPostIds { get; set; }
        public decimal TotalCosts { get; set; }

        public long OrderTaskId { get; set; }
        public string OrderTaskAbbreviation { get; set; }
        public string OrderTaskDescription { get; set; }

        public long? OrderLineId { get; set; }
        public long? OrderLineUnitId { get; set; }
        public string OrderLineUnitAbbreviation { get; set; }
        public long? OrderLineArticleId { get; set; }
        public long? OrderLineArticleGroupId { get; set; }
        public string OrderLineArticleGroupDescription { get; set; }
        public string OrderLineArticleNumber { get; set; }
        public decimal? OrderLineQuantity { get; set; }
    }
}