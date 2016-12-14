

namespace Xena.Contracts.Domain
{
    public class XenaUserSubscriptionDto : XenaUserDto, IXenaSubscriptionDto
    {
        public string Description { get; set; }
        public decimal PriceNettTotal { get; set; }
        public decimal VatEstTotal { get; set; }

        public decimal Total
        { get; set; }
        public bool IsActive { get; set; }
        public int StartDateDays { get; set; }
        public int? EndDateDays { get; set; }
        public int NextRunDateDays { get; set; }
        public string IntervalType { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public int Interval { get; set; }
        public long? SubscriptionTicketId { get; set; }
        public string NextRunDateDaysFriendly
        { get; set; }
        public string IntervalTypeFriendly
        { get; set; }
        public string IntervalDescription
        { get; set; }
    }

    public interface IXenaSubscriptionDto
    {
        long Id { get; set; }
        long FiscalSetupId { get; set; }
        string CurrencyAbbreviation { get; set; }
    }
}