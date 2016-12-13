namespace Xena.Contracts.Helpers
{
    public class LedgerTagStatistic
    {
        public long Id { get; set; }
        public string PeriodDescription { get; set; }
        public decimal Period { get; set; }
        public decimal? Period_LastYear { get; set; }
        public decimal? Difference => Period - Period_LastYear;
        public decimal? DifferenceRatio => Period_LastYear.HasValue && Period_LastYear != decimal.Zero ? Period/Period_LastYear.Value * 100M : (decimal?)null;
    }
}