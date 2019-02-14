using System.ComponentModel;

namespace Xena.Contracts.Helpers
{
    public class HistoricStockValueData
    {
        public long? Id { get; set; }
        public long ArticleId { get; set; }
        public string ArticleNumber { get; set; }
        public string ArticleDescription { get; set; }
        public long? ArticleGroupId { get; set; }
        public string ArticleGroupDescription { get; set; }
        public long FiscalSetupId { get; set; }
        public decimal AvailableQuantity { get; set; }

        private decimal? _averageCostPrice;
        [ReadOnly(true)]
        public decimal? AverageCostPrice
        {
            get
            {
                return _averageCostPrice ?? (AvailableQuantity != decimal.Zero
                           ? TotalStockValue / AvailableQuantity
                           : (decimal?) null);
            }
            set { _averageCostPrice = value; }
        }

        public decimal TotalStockValue { get; set; }
    }
}