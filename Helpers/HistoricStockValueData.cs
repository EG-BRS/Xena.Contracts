namespace Xena.Contracts.Helpers
{
    public class HistoricStockValueData
    {
        public long? Id { get; set; }
        public long ArticleId { get; set; }
        public string ArticleNumber { get; set; }
        public string ArticleDescription { get; set; }
        public long ArticleGroupId { get; set; }
        public string ArticleGroupDescription { get; set; }
        public long FiscalSetupId { get; set; }
        public decimal AvailableQuantity { get; set; }
        public decimal? AverageCostPrice { get; set; }
        public decimal? TotalStockValue => AvailableQuantity * AverageCostPrice;
    }
}