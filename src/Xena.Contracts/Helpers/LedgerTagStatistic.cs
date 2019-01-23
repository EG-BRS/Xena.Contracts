using System.ComponentModel;

namespace Xena.Contracts.Helpers
{
    public class LedgerTagStatistic
    {
        public long Id { get; set; }
        public string PeriodDescription { get; set; }
        public decimal Period { get; set; }
        public decimal? Period_LastYear { get; set; }
        private decimal? _difference = null;
        [ReadOnly(true)]
        public decimal? Difference
        {
            get { return _difference ?? (Period - Period_LastYear); }
            set { _difference = value; }
        }
        private decimal? _differenceRatio = null;
        [ReadOnly(true)]
        public decimal? DifferenceRatio
        {
            get
            {
                return _differenceRatio ?? (Period_LastYear.HasValue && Period_LastYear != decimal.Zero
                           ? Period / Period_LastYear.Value * 100M
                           : (decimal?) null);
            }
            set { _differenceRatio = value; }
        }
    }
}