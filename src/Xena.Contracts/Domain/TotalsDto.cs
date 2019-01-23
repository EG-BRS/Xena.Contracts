using System;
using System.ComponentModel;

namespace Xena.Contracts.Domain
{
    public class TotalsDto
    {
        public decimal PriceNettTotal { get; set; }
        public decimal CostTotal { get; set; }
        private decimal? _discountTotalRatio = null;
        [ReadOnly(true)]
        public decimal DiscountTotalRatio
        {
            get
            {
                return _discountTotalRatio ?? ((PriceNettTotal + DiscountTotal) == decimal.Zero
                           ? decimal.Zero
                           : DiscountTotal / (PriceNettTotal + DiscountTotal));
            }
            set { _discountTotalRatio = value; }
        }

        private decimal? _discountTotalPct = null;
        [ReadOnly(true)]
        public decimal DiscountTotalPct
        {
            get { return _discountTotalPct ?? Math.Round(DiscountTotalRatio * 100, 1, MidpointRounding.AwayFromZero); }
            set { _discountTotalPct = value; }
        }
        public decimal DiscountTotal { get; set; }
        public decimal MarginTotal { get; set; }
        private decimal? _marginTotalRatio = null;
        [ReadOnly(true)]
        public decimal MarginTotalRatio
        {
            get
            {
                return _marginTotalRatio ??
                       (PriceNettTotal == decimal.Zero ? decimal.Zero : MarginTotal / PriceNettTotal);
            }
            set { _marginTotalRatio = value; }
        }

        private decimal? _marginTotalPct = null;
        [ReadOnly(true)]
        public decimal MarginTotalPct
        {
            get { return _marginTotalPct ?? Math.Round(MarginTotalRatio * 100, 1, MidpointRounding.AwayFromZero); }
            set { _marginTotalPct = value; }
        }
        public decimal VatEstTotal { get; set; }
    }
}