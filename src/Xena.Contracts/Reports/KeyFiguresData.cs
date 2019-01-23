using System.ComponentModel;

namespace Xena.Contracts.Reports
{
    public class KeyFiguresData
    {
        public string Description { get; set; }
        public decimal PriceNetTotal { get; set; }
        public decimal CostTotal { get; set; }
        public decimal CalculatedCostTotal { get; set; }
        private decimal? _margin = null;
        [ReadOnly(true)]
        public decimal Margin
        {
            get { return _margin ?? (PriceNetTotal - CostTotal); }
            set { _margin = value; }
        }
        private decimal? _marginPct = null;
        [ReadOnly(true)]
        public decimal MarginPct
        {
            get { return _marginPct ?? (PriceNetTotal == decimal.Zero? decimal.Zero : Margin / PriceNetTotal* 100); }
            set { _marginPct = value; }
        }
        public decimal Hours { get; set; }
        private decimal? _marginPrHour = null;
        [ReadOnly(true)]
        public decimal MarginPrHour
        {
            get { return _marginPrHour ?? (Hours == decimal.Zero? decimal.Zero : Margin / Hours); }
            set { _marginPrHour = value; }
        }
    }
}