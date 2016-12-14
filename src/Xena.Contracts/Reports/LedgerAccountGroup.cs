using System.Collections.Generic;


namespace Xena.Contracts.Reports
{
    public class LedgerAccountGroup
    {
        public string LedgerAccount { get; set; }
        public string LedgerAccountTranslated
        { get; set; }
        public List<LedgerPostDtoGroup> LedgerPostGroups { get; set; } 
    }
}