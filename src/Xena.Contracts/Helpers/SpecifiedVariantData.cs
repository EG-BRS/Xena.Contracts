namespace Xena.Contracts.Helpers
{
    public class SpecifiedVariantData
    {
        public string ArticleDescription { get; set; }
        public string LocationAbbreviation { get; set; }
        public long ArticleId { get; set; }
        public decimal Quantity { get; set; }
        public long? VariantId { get; set; }
        public long? LocationId { get; set; }
    }
}