using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class FiscalPeriodDto : EntityDto
    {
        public int FiscalPeriodStartDays { get; set; }
        public string FiscalPeriodStartDaysFriendly
        {
            get { return FiscalPeriodStartDays.FriendlyString(); }
        }
        public int FiscalPeriodEndDays { get; set; }
        public string FiscalPeriodEndDaysFriendly
        {
            get { return FiscalPeriodEndDays.FriendlyString(); }
        }
        public int? LockedAtDays { get; set; }
        public string LockedAtDaysFriendly
        {
            get { return LockedAtDays.HasValue? LockedAtDays.Value.FriendlyString() : null; }
        }
        public string Description { get; set; }
        public bool IsClosed { get; set; }
        public bool IsDirty { get; set; }
    }
}