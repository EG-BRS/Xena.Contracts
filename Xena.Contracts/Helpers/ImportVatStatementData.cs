namespace Xena.Contracts.Helpers
{
    public class ImportVatStatementData
    {
        public long? ImportVatId { get; set; }
        public decimal Amount { get; set; }
        public int? PayDate { get; set; }
        public long? PaymentLedgerTagId { get; set; }
        public string Description { get; set; }
    }
}