using System.Collections.Generic;
using System.Linq;

namespace Xena.Contracts.Reports.FiscalBalance
{
    public class FiscalBalanceDetailGroupData
    {
        public FiscalBalanceDetailGroupData()
        {
            Details = new List<FiscalBalanceDetailDataDto>();
        }
        public IList<FiscalBalanceDetailDataDto> Details { get; set; }
        public string Description { get; set; }
        public decimal AmountMonth
        { get; set; }
        public decimal AmountYearToDate
        { get; set; }
        public decimal AmountMonthPreviousYear
        { get; set; }
        public decimal AmountYearToDatePreviousYear
        { get; set; }
    }
}