namespace Xena.Contracts.Domain
{
    public class StockCountDto : EntityDto
    {
        public long? LocationId { get; set; }
        public string LocationAbbreviation { get; set; }
        public long? WarehouseId { get; set; }
        public string WarehouseDescription { get; set; }
        public int? LastCountedDateDays { get; set; }
        public int CountingDateDays { get; set; }
        public string Description { get; set; }
        public long? ArticleId { get; set; }
        public string ArticleNumber { get; set; }
        public bool ArticleHasVariants { get; set; }
        public string ArticleDescription { get; set; }
        public long? ArticleGroupId { get; set; }
        public string ArticleGroupDescription { get; set; }
        public bool IsBookkeeping { get; set; }
        public bool LinesAreCreated { get; set; }
    }
}