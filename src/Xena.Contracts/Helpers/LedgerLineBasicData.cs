namespace Xena.Contracts.Helpers
{
    public class LedgerLineBasicData
    {
        public int FiscalDateDays { get; set; }
        public long LedgerTagId { get; set; }
        public int InvoiceNumber { get; set; }
        public decimal Amount { get; set; }
        public int CustomerNumber { get; set; }
    }
}
