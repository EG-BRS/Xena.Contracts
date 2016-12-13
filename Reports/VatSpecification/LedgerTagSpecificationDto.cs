using System.Collections.Generic;
using Xena.Contracts.Domain;

namespace Xena.Contracts.Reports.VatSpecification
{
    public class LedgerTagSpecificationDto
    {
        public LedgerTagDto LedgerTag { get; set; }
        public decimal StartingAmount { get; set; }
        public IList<LedgerTagSpecificationPostDto> LedgerPosts { get; set; }
        public decimal EndAmount { get; set; }
        public FiscalPeriodDto FiscalPeriod { get; set; }
    }
}