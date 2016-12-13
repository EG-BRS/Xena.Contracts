using Xena.Contracts.Domain;

namespace Xena.Contracts.Helpers
{
    public class CalculatedFiscalPeriodChartStatisticsDto : IHasIdDto
    {
        public long? Id { get; set; }
        public long FiscalSetupId { get; set; }
        public long FiscalPeriodId { get; set; }
        public decimal Income { get; set; }
        public decimal Costs { get; set; }
        public decimal AccumulatedRevenue { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
    }
}