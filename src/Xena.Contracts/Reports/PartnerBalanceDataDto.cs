namespace Xena.Contracts.Reports
{
    public class PartnerBalanceDataDto
    {
        public long PartnerId { get; set; }
        public int AccountNumber { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
    }
}