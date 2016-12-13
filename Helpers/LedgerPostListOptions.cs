namespace Xena.Contracts.Helpers
{
    public class LedgerPostListOptions : ListOptions
    {
        public LedgerPostListOptions()
        {
            IncludeRunningTotals = true;
        }
        public bool IncludeRunningTotals { get; set; }
    }
}