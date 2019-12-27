using System.Collections.Generic;
using System.ComponentModel;
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

        private decimal? _endTotal = null;
        [ReadOnly(true)]
        public decimal EndTotal
        {
            get { return _endTotal ?? (StartingTotal + PartnerPosts.Sum(pp => pp.RemainingAmount)); }
            set { _endTotal = value; }
        }
    }
}