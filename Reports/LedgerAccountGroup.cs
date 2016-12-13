using System.Collections.Generic;
using Xena.Resources;

namespace Xena.Contracts.Reports
{
    public class LedgerAccountGroup
    {
        public string LedgerAccount { get; set; }
        public string LedgerAccountTranslated
        {
            get { return LedgerAccount.GetLocalizedConstant(); }
        }
        public List<LedgerPostDtoGroup> LedgerPostGroups { get; set; } 
    }
}