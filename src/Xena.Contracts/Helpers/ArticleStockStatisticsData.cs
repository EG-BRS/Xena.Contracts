using System.ComponentModel;

namespace Xena.Contracts.Helpers
{
    public class ArticleStockStatisticsData
    {
        public long ArticleId { get; set; }
        public string ArticleNumber { get; set; }
        public string ArticleDescription { get; set; }
        public decimal OpeningStock { get; set; }
        public decimal StockPurchased { get; set; }
        public decimal StockSold { get; set; }
        private decimal? _closingStock;
        [ReadOnly(true)]
        public decimal ClosingStock
        {
            get { return _closingStock ?? (OpeningStock + StockPurchased - StockSold); }
            set { _closingStock = value; }
        }
        public decimal? EstimatedPurchasePrice { get; set; }
        public long? SupplierId { get; set; }
        public string SupplierName { get; set; }
        public int? SupplierAccountNumber { get; set; }
    }
}