using System.Collections.Generic;
using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Reports
{
    public class LedgerAccountGroup
    {
        public string LedgerAccount { get; set; }
        private string _ledgerAccountTranslated = null;
        [ReadOnly(true)]
        public string LedgerAccountTranslated
        {
            get { return _ledgerAccountTranslated ?? LedgerAccount.GetLocalizedConstant(); }
            set { _ledgerAccountTranslated = value; }
        }
        public List<LedgerPostDtoGroup> LedgerPostGroups { get; set; } 
    }
}