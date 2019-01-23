using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class FiscalPeriodDto : EntityDto
    {
        public int FiscalPeriodStartDays { get; set; }
        public int FiscalPeriodEndDays { get; set; }
        public int? LockedAtDays { get; set; }
        public string Description { get; set; }
        public bool IsClosed { get; set; }
        [ReadOnly(true)]
        public bool IsDirty { get; set; }

        //Convinience properties
        private string _fiscalPeriodStartDaysFriendly;
        [ReadOnly(true)]
        public string FiscalPeriodStartDaysFriendly
        {
            get { return _fiscalPeriodStartDaysFriendly ?? FiscalPeriodStartDays.FriendlyString(); }
            set { _fiscalPeriodStartDaysFriendly = value; }
        }

        private string _fiscalPeriodEndDaysFriendly;
        [ReadOnly(true)]
        public string FiscalPeriodEndDaysFriendly
        {
            get { return _fiscalPeriodEndDaysFriendly ?? FiscalPeriodEndDays.FriendlyString(); }
            set { _fiscalPeriodEndDaysFriendly = value; }
        }

        private string _lockedAtDaysFriendly;
        [ReadOnly(true)]
        public string LockedAtDaysFriendly
        {
            get { return _lockedAtDaysFriendly ?? LockedAtDays?.FriendlyString(); }
            set { _lockedAtDaysFriendly = value; }
        }
    }
}