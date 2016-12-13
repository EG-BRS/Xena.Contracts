namespace Xena.Contracts.Helpers
{
    public class ReconciliationData
    {
        public long[] BankPostingIds { get; set; }
        public long[] LedgerPostIds { get; set; }
    }

    public class ReconciliationDataWithLedgerTagId : ReconciliationData
    {
        public long? LedgerTagId { get; set; }
    }
}