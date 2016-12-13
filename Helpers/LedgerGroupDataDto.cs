using System;
using System.Security.Policy;

namespace Xena.Contracts.Helpers
{
    public class LedgerGroupDataDto
    {
        public decimal AmountMonth { get; set; }
        public decimal? AmountMonthDebit { get { return AmountMonth > 0 ? Math.Abs(AmountMonth) : (decimal?)null; } }
        public decimal? AmountMonthCredit { get { return AmountMonth < 0 ? Math.Abs(AmountMonth) : (decimal?)null; } }
        public string Group { get; set; }
        public decimal AmountYearToDate { get; set; }
        public decimal? AmountYearToDateDebit { get { return AmountYearToDate > 0 ? Math.Abs(AmountYearToDate) : (decimal?)null; } }
        public decimal? AmountYearToDateCredit { get { return AmountYearToDate < 0 ? Math.Abs(AmountYearToDate) : (decimal?)null; } }
        public string TranslatedGroup { get; set; }
    }

    public class LedgerGroupDataDetailDto
    {
        public string Controller { get; set; }
        public string ControllerAction { get; set; }
        public object Id { get; set; }
        public string Description { get; set; }
        public decimal AmountMonth { get; set; }
        public decimal? AmountMonthDebit => AmountMonth > 0 ? Math.Abs(AmountMonth) : (decimal?)null;
        public decimal? AmountMonthCredit { get { return AmountMonth < 0 ? Math.Abs(AmountMonth) : (decimal?)null; } }
        public decimal AmountYearToDate { get; set; }
        public decimal? AmountYearToDateDebit { get { return AmountYearToDate > 0 ? Math.Abs(AmountYearToDate) : (decimal?)null; } }
        public decimal? AmountYearToDateCredit { get { return AmountYearToDate < 0 ? Math.Abs(AmountYearToDate) : (decimal?)null; } }
        public string LedgerAccount { get; set; }
        public string Group { get; set; }
        public int GroupIndex { get; set; }
    }
}