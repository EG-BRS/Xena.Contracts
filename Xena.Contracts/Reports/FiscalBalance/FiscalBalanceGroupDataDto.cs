using System.Collections.Generic;

namespace Xena.Contracts.Reports.FiscalBalance
{
    /// <summary>
    /// Income-, asset- or liabilitystatement
    /// </summary>
    public class FiscalBalanceGroupDataDto
    {
        public string Description { get; set; }
        public decimal AmountMonth { get; set; }
        public decimal AmountYearToDate { get; set; }
        public decimal AmountMonthPreviousYear { get; set; }
        public decimal AmountYearToDatePreviousYear { get; set; }
        public string TranslatedDescription { get; set; }
        public IList<FiscalBalanceGroupDetailDataDto> Details { get; set; }
    }
}