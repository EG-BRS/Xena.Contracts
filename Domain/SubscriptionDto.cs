using System;
using Xena.Resources;
using Xena.Resources.Constants;

namespace Xena.Contracts.Domain
{
    public class SubscriptionDto : EntityDto
    {
        private TotalsDto _totals;

        public SubscriptionDto()
        {
            IntervalType = IntervalTypes.Months;
            Interval = 1;
            NextRunDateDays = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(1).DaysSince1970_01_01();
            StartDateDays = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(1).DaysSince1970_01_01();
        }

        public long? CustomerId { get; set; }
        public int NextRunDateDays { get; set; }
        public int StartDateDays { get; set; }
        public int? EndDateDays { get; set; }
        public long? CustomerContextId { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public string InvoiceEmail { get; set; }
        public DimensionsDto Dimensions { get; set; }
        public TermsOfPaymentDto TermsOfPayment { get; set; }
        public bool IsActive { get; set; }
        public int Interval { get; set; }
        public string IntervalType { get; set; }
        public int PartnerAccountNumber { get; set; }
        public string PartnerName { get; set; }
        public string PartnerPhoneNumber { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public long? SubscriptionTicketId { get; set; }
        public TotalsDto Totals
        {
            get { return _totals??new TotalsDto(); }
            set { _totals = value; }
        }
        public string StartDateDaysFriendly => StartDateDays.FriendlyString();
        public string EndDateDaysFriendly => EndDateDays.HasValue ? EndDateDays.Value.FriendlyString() : string.Empty;
        public string NextRunDateDaysFriendly => NextRunDateDays.FriendlyString();
        public string IntervalTypeFriendly => IntervalType.GetLocalizedIntervalType(Interval);
        public string IntervalDescription => Interval + " " + IntervalType.GetLocalizedIntervalType(Interval);
    }
}
