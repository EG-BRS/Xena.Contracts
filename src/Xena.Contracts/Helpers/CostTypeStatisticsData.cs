namespace Xena.Contracts.Helpers
{
    public class CostTypeStatisticsData
    {
        public long? CostTypeId { get; set; }
        public string CostTypeDescription { get; set; }
        public decimal AmountTotal { get; set; }
        public decimal QuantityTotal { get; set; }
    }
}