namespace Xena.Contracts.Helpers
{
    public class LedgerTagStatistic
    {
        public long Id { get; set; }
        public string PeriodDescription { get; set; }
        public decimal Period { get; set; }
        public decimal? Period_LastYear { get; set; }
        public decimal? Difference { get; set; }
        public decimal? DifferenceRatio { get; set; }
    }
}