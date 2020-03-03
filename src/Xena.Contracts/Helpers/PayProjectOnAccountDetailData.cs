namespace Xena.Contracts.Helpers
{
    public class PayProjectOnAccountDetailData
    {
        public long OrderId { get; set; }
        public long OrderTaskId { get; set; }
        public decimal? Percentage { get; set; }
        public decimal? Amount { get; set; }
    }
}