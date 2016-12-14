

namespace Xena.Contracts.Domain
{
    public class FiscalPeriodDto : EntityDto
    {
        public int FiscalPeriodStartDays { get; set; }
        public string FiscalPeriodStartDaysFriendly
        { get; set; }
        public int FiscalPeriodEndDays { get; set; }
        public string FiscalPeriodEndDaysFriendly
        { get; set; }
        public int? LockedAtDays { get; set; }
        public string LockedAtDaysFriendly
        { get; set; }
        public string Description { get; set; }
        public bool IsClosed { get; set; }
        public bool IsDirty { get; set; }
    }
}