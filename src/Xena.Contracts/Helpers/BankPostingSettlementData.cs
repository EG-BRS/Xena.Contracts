using System.Collections.Generic;
using Xena.Contracts.Domain;

namespace Xena.Contracts.Helpers
{
    public class BankPostingSettlementData
    {
        public IList<BankPostingDto> BankPostings { get; set; }
        public IList<LedgerPostDto> LedgerPosts { get; set; }
    }
}