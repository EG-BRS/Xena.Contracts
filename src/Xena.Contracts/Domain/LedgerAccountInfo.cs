namespace Xena.Contracts.Domain
{
    public class LedgerAccountInfo
    {
        public string Id { get; set; }
        public string Account { get; set; }
        public string AccountTranslated { get; set; }
        public bool CanCreateNew { get; set; }
    }
}