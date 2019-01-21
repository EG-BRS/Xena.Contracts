using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class LedgerAccountInfo
    {
        public LedgerAccountInfo()
        {
            
        }
        public LedgerAccountInfo(string account, bool canCreateNew)
        {
            Account = account;
            AccountTranslated = account.GetLocalizedConstant();
            CanCreateNew = canCreateNew;
        }

        public string Id => Account;
        public string Account { get; set; }
        private string _accountTranslated = null;
        [ReadOnly(true)]
        public string AccountTranslated
        {
            get { return _accountTranslated ?? Account.GetLocalizedConstant(); }
            set { _accountTranslated = value; }
        }
        public bool CanCreateNew { get; set; }
    }
}