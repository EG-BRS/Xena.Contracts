namespace Xena.Contracts.Domain
{
    public class VariantDto:EntityDto
    {
        public string Description { get; set; }
        public string Abbreviation { get; set; }
        public long VariantRangeId { get; set; }

        public string VariantDescription
        { get; set; }
    }
}