using System;
using System.Collections.Generic;
using Xena.Common.ExtensionMethods;
using Xena.Common.Constants;
using System.ComponentModel;

namespace Xena.Contracts.Domain
{
    public class ReportSubscriptionDto : EntityDto
    {
        public ReportSubscriptionDto()
        {
            IntervalType = IntervalTypes.Months;
            Interval = 1;
            NextRunDateDays = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(1).DaysSince1970_01_01();
            Subscribers = new List<ReportSubscriberDto>();
            FiscalBalances = new List<FiscalBalanceContextDto>();
            LedgerTagStatements = new List<LedgerTagStatementContextDto>();
            PartnerSaldos = new List<PartnerSaldoContextDto>();
            PartnerSaldoAges = new List<PartnerSaldoAgeContextDto>();
        }

        public int? NextRunDateDays { get; set; }
        private string _nextRunDateDaysFriendly = null;
        [ReadOnly(true)]
        public string NextRunDateDaysFriendly
        {
            get { return _nextRunDateDaysFriendly ?? (NextRunDateDays.HasValue ? NextRunDateDays.Value.FriendlyString() : string.Empty); }
            set { _nextRunDateDaysFriendly = value; }
        }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int Interval { get; set; }
        public string IntervalType { get; set; }
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
        public IList<ReportSubscriberDto> Subscribers { get; set; } 
        public IList<FiscalBalanceContextDto> FiscalBalances { get; set; } 
        public IList<LedgerTagStatementContextDto> LedgerTagStatements { get; set; } 
        public IList<PartnerSaldoContextDto> PartnerSaldos { get; set; } 
        public IList<PartnerSaldoAgeContextDto> PartnerSaldoAges { get; set; } 
    }
}