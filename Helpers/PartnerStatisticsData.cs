namespace Xena.Contracts.Helpers
{
    public class PartnerStatisticsData
    {
        public long? Id { get; set; }
        public long PartnerId { get; set; }
        public int PartnerAccountNumber { get; set; }
        public string PartnerName { get; set; }
        public string ContextType { get; set; }
        public decimal Amount { get; set; }
    }
}