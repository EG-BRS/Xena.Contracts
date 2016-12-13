namespace Xena.Contracts.Domain
{
    public class MonthDto
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public string Description { get; set; }
        public bool IsDefault { get; set; }
    }
}