using Xena.Contracts.Domain;

namespace Xena.Contracts.Helpers
{
    public class LocationReplenishmentDto : IHasIdDto
    {
        public long? Id { get; set; }
        public long ArticleId { get; set; }
        public string ArticleDescription { get; set; }
        public string ArticleNumber { get; set; }
        public long? ArticleVariantId { get; set; }
        public string ArticleVariantAbbreviation { get; set; }
        public decimal QuantityToMove { get; set; }
        public decimal AvailableQuantity { get; set; }
        public decimal LocationMinimumQuantity { get; set; }
        public decimal LocationMaximumQuantity { get; set; }
        public long MoveToLocationId { get; set; }
        public string MoveToLocationAbbreviation { get; set; }
        public long? MoveFromLocationId { get; set; }
        public string MoveFromLocationAbbreviation { get; set; }
        public long FiscalSetupId { get; set; }
        public string ArticleShortDescription => $"{ArticleNumber} - {ArticleDescription}";
    }
}