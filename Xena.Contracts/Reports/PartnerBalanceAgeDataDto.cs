namespace Xena.Contracts.Reports
{
    public class PartnerBalanceAgeDataDto
    {
        public long PartnerId { get; set; }
        public int AccountNumber { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public decimal Balance30 { get; set; }
        public decimal Balance3060 { get; set; }
        public decimal Balance6090 { get; set; }
        public decimal Balance90 { get; set; }
    }
}