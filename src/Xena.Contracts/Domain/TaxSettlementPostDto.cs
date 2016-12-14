namespace Xena.Contracts.Domain
{
    public class TaxSettlementPostDto
    {
        public long LedgerTagId { get; set; }
        public string LedgerTagDescription { get; set; }
        public int? LedgerTagNumber { get; set; }
        public decimal AmountSettled { get; set; }
        public decimal PrimoAdjustment { get; set; }
        public decimal TotalAmount { get; set; }
    }
}