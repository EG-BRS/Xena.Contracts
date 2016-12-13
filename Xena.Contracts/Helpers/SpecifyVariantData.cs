using System.Collections.Generic;

namespace Xena.Contracts.Helpers
{
    public class SpecifyVariantData
    {
        public IList<SpecifiedVariantData> VariantLines { get; set; }
        public long ArticleId { get; set; }
        public long? LocationId { get; set; }
        public decimal AvailableQuantity { get; set; }
        public long? ArticleVariantId { get; set; }
    }
}