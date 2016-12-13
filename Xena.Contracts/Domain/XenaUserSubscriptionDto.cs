using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class XenaUserSubscriptionDto : XenaUserDto, IXenaSubscriptionDto
    {
        public string Description { get; set; }
        public decimal PriceNettTotal { get; set; }
        public decimal VatEstTotal { get; set; }

        public decimal Total
        {
            get { return PriceNettTotal + VatEstTotal; }
        }
        public bool IsActive { get; set; }
        public int StartDateDays { get; set; }
        public int? EndDateDays { get; set; }
        public int NextRunDateDays { get; set; }
        public string IntervalType { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public int Interval { get; set; }
        public long? SubscriptionTicketId { get; set; }
        public string NextRunDateDaysFriendly
        {
            get { return NextRunDateDays.FriendlyString(); }
        }
        public string IntervalTypeFriendly
        {
            get { return IntervalType.GetLocalizedIntervalType(Interval); }
        }
        public string IntervalDescription
        {
            get { return Interval + " " + IntervalType.GetLocalizedIntervalType(Interval); }
        }
    }

    public interface IXenaSubscriptionDto
    {
        long Id { get; set; }
        long FiscalSetupId { get; set; }
        string CurrencyAbbreviation { get; set; }
    }
}