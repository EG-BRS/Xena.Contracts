using System.Collections.Generic;

namespace Xena.Contracts.Reports.WorkInProgress
{
    public class WorkInProgressData
    {
        public IEnumerable<WorkInProgressDetailData> Details { get; set; }
        public decimal CostTotal { get; set; }
        public decimal InvoicedTotal { get; set; }
    }
}