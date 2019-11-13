namespace Xena.Contracts.Reports
{
    public class PartnerBalanceByDueDateDto
    {
        public long PartnerId { get; set; }
        public int AccountNumber { get; set; }
        public string Name { get; set; }
        public decimal Interval { get; set; }
        public decimal TotalBalance { get; set; }
        public decimal FirstIntervalBalance { get; set; }
        public decimal SecondIntervalBalance { get; set; }
        public decimal ThirdIntervalBalance { get; set; }
        public decimal FourthIntervalBalance { get; set; }
    }
}
