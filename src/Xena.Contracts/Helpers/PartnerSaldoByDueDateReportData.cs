namespace Xena.Contracts.Helpers
{
    public class PartnerSaldoByDueDateReportData
    {
        public int CalculatedBy { get; set; }
        public int Interval { get; set; }
        public string ScheduleMethod { get; set; }
        public long? ReportLayoutId { get; set; }
        public string ContextType { get; set; } 
    }
}