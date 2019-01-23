using System;
using System.ComponentModel;

namespace Xena.Contracts.Domain
{
    public class ProjectCalculationPostDto : EntityDto
    {
        public long ProjectId { get; set; }
        public long? CostTypeId { get; set; }
        public string CostTypeDescription { get; set; }
        public decimal? CostTypeDefaultMargin { get; set; }
        public decimal Cost { get; set; }
        public decimal Margin { get; set; }
        public decimal? Hours { get; set; }
        public string Description { get; set; }
        private decimal? _calculatedTotal = null;
        [ReadOnly(true)]
        public decimal CalculatedTotal
        {
            get
            {
                if (_calculatedTotal.HasValue)
                {
                    return _calculatedTotal.Value;
                }
                var percentage = (100M - Margin) / 100;
                return Math.Round(Cost / (percentage == decimal.Zero ? 1 : percentage), 0, MidpointRounding.AwayFromZero);
            }
            set { _calculatedTotal = value; }
        }
}
}