namespace Xena.Contracts.Domain
{
    public class VatSettlementPostDto
    {
        public long VatId { get; set; }
        public string VatAbbreviation { get; set; }
        public string VatType { get; set; }
        public decimal Basis { get; set; }
        public decimal AmountSettled { get; set; }
        public decimal PrimoAdjustment { get; set; }
        public decimal TotalAmount { get; set; }
    }
}