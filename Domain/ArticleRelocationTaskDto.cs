namespace Xena.Contracts.Domain
{
    public class ArticleRelocationTaskDto : EntityDto
    {
        public long ArticleId { get; set; }
        public string ArticleNumber { get; set; }
        public string ArticleDescription { get; set; }
        public long? ArticleVariantId { get; set; }
        public string ArticleVariantAbbreviation { get; set; }
        public long? LocationFromId { get; set; }
        public string LocationFromAbbreviation { get; set; }
        public long? LocationToId { get; set; }
        public string LocationToAbbreviation { get; set; }
        public decimal Quantity { get; set; }
    }
}