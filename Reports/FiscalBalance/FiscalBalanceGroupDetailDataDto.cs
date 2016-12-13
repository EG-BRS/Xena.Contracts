using System.Collections.Generic;

namespace Xena.Contracts.Reports.FiscalBalance
{
    /// <summary>
    /// Ledgeraccount summary
    /// </summary>
    public class FiscalBalanceGroupDetailDataDto
    {
        public FiscalBalanceGroupDetailDataDto()
        {
            Details = new List<FiscalBalanceDetailDataDto>();
            GroupedDetails = new List<FiscalBalanceDetailGroupData>();
        }
        public string Description { get; set; }
        public decimal AmountMonth { get; set; }
        public decimal AmountYearToDate { get; set; }
        public decimal AmountMonthPreviousYear { get; set; }
        public decimal AmountYearToDatePreviousYear { get; set; }
        public string TranslatedGroup { get; set; }
        public IList<FiscalBalanceDetailDataDto> Details { get; set; }
        public IList<FiscalBalanceDetailGroupData> GroupedDetails { get; set; }
    }
}