using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class LedgerTagGroupDto : EntityDto
    {
        public string LedgerAccount { get; set; }
        public string Description { get; set; }
        public int Index { get; set; }
        private string _ledgerAccountTranslated = null;
        [ReadOnly(true)]
        public string LedgerAccountTranslated
        {
            get
            {
                return _ledgerAccountTranslated ?? (string.IsNullOrEmpty(LedgerAccount)
                           ? string.Empty
                           : LedgerAccount.GetLocalizedConstant());
            }
            set { _ledgerAccountTranslated = value; }
        }
    }
}