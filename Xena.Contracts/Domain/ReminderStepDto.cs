namespace Xena.Contracts.Domain
{
    public class ReminderStepDto : EntityDto
    {
        public string Description { get; set; }
        public long? ReportLayoutId { get; set; }
        public string ReportLayoutName { get; set; }
        public int GracePeriodInDays { get; set; }
        public decimal? InterestRate { get; set; }
        public decimal? Fee { get; set; }
    }
}