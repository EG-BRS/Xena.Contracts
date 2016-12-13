using System;

namespace Xena.Contracts.Domain
{
    public class TotalsDto
    {
        public decimal PriceNettTotal { get; set; }
        public decimal CostTotal { get; set; }
        public decimal DiscountTotalRatio
        {
            get
            {
                return (PriceNettTotal + DiscountTotal) == decimal.Zero
                           ? decimal.Zero
                           : DiscountTotal/(PriceNettTotal + DiscountTotal);
            }
            set { }
        }
        public decimal DiscountTotalPct
        {
            get { return Math.Round(DiscountTotalRatio*100, 1, MidpointRounding.AwayFromZero); }
            set { }
        }
        public decimal DiscountTotal { get; set; }
        public decimal MarginTotal { get; set; }
        public decimal MarginTotalRatio
        {
            get { return PriceNettTotal == decimal.Zero ? decimal.Zero : MarginTotal/PriceNettTotal; }
            set { }
        }
        public decimal MarginTotalPct
        {
            get { return Math.Round(MarginTotalRatio*100, 1, MidpointRounding.AwayFromZero); }
            set { }
        }
        public decimal VatEstTotal { get; set; }
    }
}