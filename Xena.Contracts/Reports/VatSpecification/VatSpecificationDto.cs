using System.Collections.Generic;

namespace Xena.Contracts.Reports.VatSpecification
{
    public class VatSpecificationDto
    {
        public string SettlementType { get; set; }
        public string Description { get; set; }
        public decimal PeriodTotal { get; set; }
        public decimal CalculatedPeriodTotal { get; set; }
        public decimal Difference { get; set; }
        public decimal AdjustmentsPrevPeriods { get; set; }
        public IList<VatSpecificationDetailsDataDto> Details { get; set; }
        public IList<VatSpecificationDeviationDataDto> Deviations { get; set; }
        public decimal Percentage { get; set; }
    }
}