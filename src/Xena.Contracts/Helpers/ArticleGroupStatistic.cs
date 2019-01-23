using System.ComponentModel;

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

        private decimal? _margin_Period;
        [ReadOnly(true)]
        public decimal Margin_Period
        {
            get { return _margin_Period ?? Turnover_Period + Consumption_Period; }
            set { _margin_Period = value; }
        }

        private decimal? _margin_Period_LastYear;
        [ReadOnly(true)]
        public decimal? Margin_Period_LastYear
        {
            get
            {
                return _margin_Period_LastYear ?? (Turnover_Period_LastYear.HasValue || Consumption_Period_LastYear.HasValue
                    ? (Turnover_Period_LastYear ?? decimal.Zero) + (Consumption_Period_LastYear ?? decimal.Zero)
                    : (decimal?) null);
            }
            set { _margin_Period_LastYear = value; }
        }

        private decimal? _margin_Period_Ratio;
        [ReadOnly(true)]
        public decimal Margin_Period_Ratio
        {
            get { return _margin_Period_Ratio ?? (Turnover_Period == decimal.Zero ? decimal.Zero : Margin_Period / Turnover_Period * 100.0m); }
            set { _margin_Period_Ratio = value; }
        }

        private decimal? _margin_Period_LastYear_Ratio;
        [ReadOnly(true)]
        public decimal? Margin_Period_LastYear_Ratio
        {
            get
            {
                return _margin_Period_LastYear_Ratio ?? (!Turnover_Period_LastYear.HasValue || !Margin_Period_LastYear.HasValue
                    ? (decimal?) null
                    : Turnover_Period_LastYear.Value == decimal.Zero
                        ? decimal.Zero
                        : Margin_Period_LastYear.Value / Turnover_Period_LastYear.Value * 100.0m);
            }
            set { _margin_Period_LastYear_Ratio = value; }
        }
    }
}