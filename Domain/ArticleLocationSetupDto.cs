namespace Xena.Contracts.Domain
{
    public class ArticleLocationSetupDto : EntityDto
    {
        public long? ArticleId { get; set; }
        public string ArticleNumber { get; set; }
        public string ArticleDescription { get; set; }
        public long? ArticleVariantId { get; set; }
        public string ArticleVariantAbbreviation { get; set; }
        public long? LocationId { get; set; }
        public string LocationAbbreviation { get; set; }
        public string LocationDescription { get; set; }
        public decimal MinimumQuantity { get; set; }
        public decimal MaximumQuantity { get; set; }
    }
}