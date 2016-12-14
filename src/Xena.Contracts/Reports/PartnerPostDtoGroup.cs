using System.Collections.Generic;
using System.Linq;
using Xena.Contracts.Domain;

namespace Xena.Contracts.Reports
{
    public class PartnerPostDtoGroup
    {
        public string PartnerName { get; set; } 
        public int PartnerAccountNumber { get; set; }
        public List<PartnerPostDto> PartnerPosts { get; set; }
        public decimal StartingTotal { get; set; }

        public decimal EndTotal
        { get; set; }
    }
}