namespace Xena.Contracts.Domain
{
    public class VatTotalsDto
    {
        public decimal Basis { get; set; }
        public decimal VatAmount { get; set; }
        public decimal Percentage { get; set; }
        public long? VatId { get; set; }
    }
}