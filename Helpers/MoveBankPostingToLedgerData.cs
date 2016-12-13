namespace Xena.Contracts.Helpers
{
    public class MoveBankPostingToLedgerData
    {
        public long LedgerId { get; set; }
        public int? FiscalDateTo { get; set; }
        public int? FiscalDateFrom { get; set; }
    }
}