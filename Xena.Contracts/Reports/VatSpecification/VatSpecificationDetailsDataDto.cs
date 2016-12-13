namespace Xena.Contracts.Reports.VatSpecification
{
    public class VatSpecificationDetailsDataDto
    {
        public string DetailType { get; set; }
        public string Description { get; set; }
        public decimal Basis { get; set; }
        public decimal PeriodTotal { get; set; }
        public decimal CalculatedPeriodTotal { get; set; }
        public decimal Difference { get; set; }
        public decimal AdjustmentsPrevPeriods { get; set; }
    }
}