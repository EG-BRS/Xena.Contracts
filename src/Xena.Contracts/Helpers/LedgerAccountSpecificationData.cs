using System.Collections.Generic;
using System.ComponentModel;
using Xena.Contracts.Domain;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Helpers
{
    public class LedgerAccountSpecificationData
    {
        public const string LedgerTagType= "ledger_tag"; 
        public const string VATType ="vat"; 
        public const string LedgerAccountType = "ledger_account"; 
        public const string ArticleGroupType =  "article_group"; 
        public object Id { get; set; }
        public long? EntityId { get; set; }
        public string Type { get; set; }
        public int? Number { get; set; }
        public string Description { get; set; }
        public string LedgerAccount { get; set; }
        public decimal StartingBalance { get; set; }
        public decimal EndBalance { get; set; }
        public IList<LedgerPostDto> Movements { get; set; }

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