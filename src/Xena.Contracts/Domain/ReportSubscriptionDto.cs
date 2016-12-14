using System;
using System.Collections.Generic;



namespace Xena.Contracts.Domain
{
    public class ReportSubscriptionDto : EntityDto
    {
        public ReportSubscriptionDto()
        {
            //IntervalType = IntervalTypes.Months;
            Interval = 1;
            //NextRunDateDays = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(1).DaysSince1970_01_01();
            Subscribers = new List<ReportSubscriberDto>();
            FiscalBalances = new List<FiscalBalanceContextDto>();
            LedgerTagStatements = new List<LedgerTagStatementContextDto>();
            PartnerSaldos = new List<PartnerSaldoContextDto>();
            PartnerSaldoAges = new List<PartnerSaldoAgeContextDto>();
        }

        public int? NextRunDateDays { get; set; }
        public string NextRunDateDaysFriendly
        { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public int Interval { get; set; }
        public string IntervalType { get; set; }
        public string IntervalTypeFriendly
        { get; set; }
        public string IntervalDescription
        { get; set; }
        public IList<ReportSubscriberDto> Subscribers { get; set; } 
        public IList<FiscalBalanceContextDto> FiscalBalances { get; set; } 
        public IList<LedgerTagStatementContextDto> LedgerTagStatements { get; set; } 
        public IList<PartnerSaldoContextDto> PartnerSaldos { get; set; } 
        public IList<PartnerSaldoAgeContextDto> PartnerSaldoAges { get; set; } 
    }
}