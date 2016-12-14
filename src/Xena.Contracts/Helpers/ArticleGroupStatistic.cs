namespace Xena.Contracts.Helpers
{
    public class ArticleGroupStatistic
    {
        public long Id { get; set; }
        public string PeriodDescription { get; set; }
        public decimal Turnover_Period { get; set; }
        public decimal? Turnover_Period_LastYear { get; set; }
        public decimal Consumption_Period { get; set; }
        public decimal? Consumption_Period_LastYear { get; set; }
        public decimal Margin_Period { get; set; }
        public decimal? Margin_Period_LastYear { get; set; }
        public decimal Margin_Period_Ratio { get; set; }
        public decimal? Margin_Period_LastYear_Ratio => !Turnover_Period_LastYear.HasValue || !Margin_Period_LastYear.HasValue
            ? (decimal?)null
            : Turnover_Period_LastYear.Value == decimal.Zero 
                ? decimal.Zero 
                : Margin_Period_LastYear.Value / Turnover_Period_LastYear.Value  * 100.0m;
    }
}