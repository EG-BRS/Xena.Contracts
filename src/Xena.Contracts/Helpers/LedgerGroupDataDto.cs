using System;

namespace Xena.Contracts.Helpers
{
    public class LedgerGroupDataDto
    {
        public decimal AmountMonth { get; set; }
        public decimal? AmountMonthDebit { get; set; }
        public decimal? AmountMonthCredit { get; set; }
        public string Group { get; set; }
        public decimal AmountYearToDate { get; set; }
        public decimal? AmountYearToDateDebit { get; set; }
        public decimal? AmountYearToDateCredit { get; set; }
        public string TranslatedGroup { get; set; }
    }

    public class LedgerGroupDataDetailDto
    {
        public string Controller { get; set; }
        public string ControllerAction { get; set; }
        public object Id { get; set; }
        public string Description { get; set; }
        public decimal AmountMonth { get; set; }
        public decimal? AmountMonthDebit { get; set; }
        public decimal? AmountMonthCredit { get; set; }
        public decimal AmountYearToDate { get; set; }
        public decimal? AmountYearToDateDebit { get; set; }
        public decimal? AmountYearToDateCredit { get; set; }
        public string LedgerAccount { get; set; }
        public string Group { get; set; }
        public int GroupIndex { get; set; }
    }
}