using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class XenaUserSubscriptionDto : XenaUserDto, IXenaSubscriptionDto
    {
        public string Description { get; set; }
        public decimal PriceNettTotal { get; set; }
        public decimal VatEstTotal { get; set; }

        private decimal? _total = null;
        [ReadOnly(true)]
        public decimal Total
        {
            get { return _total ?? (PriceNettTotal + VatEstTotal); }
            set { _total = value; }
        }
        public bool IsActive { get; set; }
        public int StartDateDays { get; set; }
        public int? EndDateDays { get; set; }
        public int NextRunDateDays { get; set; }
        public string IntervalType { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public int Interval { get; set; }
        public long? SubscriptionTicketId { get; set; }

        private string _nextRunDateDaysFriendly = null;
        [ReadOnly(true)]
        public string NextRunDateDaysFriendly
        {
            get { return _nextRunDateDaysFriendly ?? NextRunDateDays.FriendlyString(); }
            set { _nextRunDateDaysFriendly = value; }
        }

        private string _intervalTypeFriendly = null;
        [ReadOnly(true)]
        public string IntervalTypeFriendly
        {
            get { return _intervalTypeFriendly ?? IntervalType.GetLocalizedIntervalType(Interval); }
            set { _intervalTypeFriendly = value; }
        }

        private string _intervalDescription = null;
        [ReadOnly(true)]
        public string IntervalDescription
        {
            get { return _intervalDescription ?? (Interval + " " + IntervalType.GetLocalizedIntervalType(Interval)); }
            set { _intervalDescription = value; }
        }
    }

    public interface IXenaSubscriptionDto
    {
        long Id { get; set; }
        long FiscalSetupId { get; set; }
        string CurrencyAbbreviation { get; set; }
    }
}