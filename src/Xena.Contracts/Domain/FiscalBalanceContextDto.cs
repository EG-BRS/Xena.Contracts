using System.ComponentModel;

namespace Xena.Contracts.Domain
{
    public class FiscalBalanceContextDto : IHasIdDto
    {
        [ReadOnly(true)]
        public long? Id { get; set; }
        public long ReportSubscriptionId { get; set; }
        public long? ReportLayoutId { get; set; }
        public long? DepartmentId { get; set; }
        public long? BearerId { get; set; }
        public long? PurposeId { get; set; }
        public string ReportLayoutName { get; set; }
        public string BearerDescription { get; set; }
        public string DepartmentDescription { get; set; }
        public string PurposeDescription { get; set; }
    }
}