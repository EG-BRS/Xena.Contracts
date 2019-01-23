namespace Xena.Contracts.Helpers
{
    public class ProjectStatusData
    {
        public long ProjectId { get; set; }
        public int? ProjectNumber { get; set; }
        public string ProjectDescription { get; set; }
        public decimal CalculatedCostTotal { get; set; }
        public decimal CostTotalApproved { get; set; }
        public decimal CostTotalAwaitingApproval { get; set; }
    }
}