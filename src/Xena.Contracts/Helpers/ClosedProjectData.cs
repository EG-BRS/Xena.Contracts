using System.ComponentModel;

namespace Xena.Contracts.Helpers
{
    public class ClosedProjectData
    {
        public long ProjectId { get; set; }
        public int? ProjectNumber { get; set; }
        public string ProjectDescription { get; set; }
        public int ClosedDateDays { get; set; }

        private decimal? _margin;
        [ReadOnly(true)]
        public decimal Margin
        {
            get { return _margin ?? NettTurnover - TotalCost; }
            set { _margin = value; }
        }

        public decimal Hours { get; set; }

        private decimal? _marginPerHour;
        [ReadOnly(true)]
        public decimal MarginPerHour
        {
            get { return _marginPerHour ?? (Hours == decimal.Zero ? decimal.Zero : Margin / Hours); }
        }

        public decimal NettTurnover { get; set; }

        private decimal? _marginPercentage;
        [ReadOnly(true)]
        public decimal MarginPercentage
        {
            get { return _marginPercentage ?? (NettTurnover == decimal.Zero ? decimal.Zero : Margin / NettTurnover * 100M); }
            set { _marginPercentage = value; }
        }

        public decimal? MarginPercentageExpected { get; set; }
        public decimal TotalCost { get; set; }
    }
}