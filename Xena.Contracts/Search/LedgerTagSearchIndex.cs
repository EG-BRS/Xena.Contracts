namespace Xena.Contracts.Search
{
    public class LedgerTagSearchIndex
    {
        public long Id { get; set; }
        public long FiscalSetupId { get; set; }
        public int? Number { get; set; }
        public string NumberRaw { get; set; }
        public string Description { get; set; }
        public string LedgerAccount { get; set; }
    }
}