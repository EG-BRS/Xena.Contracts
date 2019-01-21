using System.ComponentModel;

namespace Xena.Contracts.Helpers
{
    public class ArticleMarginData
    {
        public long? Id { get; set; }
        public long ArticleId { get; set; }
        public string ArticleNumber { get; set; }
        public string ArticleDescription { get; set; }
        public long ArticleGroupId { get; set; }
        public string ArticleGroupDescription { get; set; }
        public decimal Turnover { get; set; }
        public decimal Consumption { get; set; }

        private decimal? _margin;
        [ReadOnly(true)]
        public decimal Margin
        {
            get { return _margin ?? Turnover - Consumption; }
            set { _margin = value; }
        }

        private decimal? _marginRatio;
        [ReadOnly(true)]
        public decimal? MarginRatio
        {
            get { return _marginRatio ??  (Turnover == decimal.Zero ? (decimal?) null : Margin / Turnover * 100M);}
            set { _marginRatio = value; }
        }
    }
}