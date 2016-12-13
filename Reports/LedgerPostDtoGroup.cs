using System.Collections.Generic;
using Xena.Contracts.Domain;

namespace Xena.Contracts.Reports
{
    public class LedgerPostDtoGroup
    {
        public string GroupName { get; set; } 
        public string GroupType { get; set; }
        public List<LedgerPostDto> LedgerPosts { get; set; }
        public decimal EndTotal { get; set; }
    }
}