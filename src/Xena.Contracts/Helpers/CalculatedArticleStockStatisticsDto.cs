using Xena.Contracts.Domain;

namespace Xena.Contracts.Helpers
{
    public class CalculatedArticleStockStatisticsDto:IHasIdDto
    {
        public long? Id { get; set; }
        public long FiscalSetupId { get; set; }
        public long FiscalPeriodId { get; set; }
        public decimal Stock { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public long ArticleId { get; set; }
        public long? ArticleVariantId { get; set; }
    }
}