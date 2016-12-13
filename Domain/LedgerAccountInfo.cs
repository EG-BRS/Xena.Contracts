namespace Xena.Contracts.Domain
{
    public class LedgerAccountInfo
    {
        public string Id { get { return Account; } }
        public string Account { get; set; }
        public string AccountTranslated { get; set; }
        public bool CanCreateNew { get; set; }
    }
}