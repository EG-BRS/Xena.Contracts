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
        {
            get { return Details.Sum(d => d.AmountMonth); }
        }
        public decimal AmountYearToDate
        {
            get { return Details.Sum(d => d.AmountYearToDate); }
        }
        public decimal AmountMonthPreviousYear
        {
            get { return Details.Sum(d => d.AmountMonthPreviousYear); }
        }
        public decimal AmountYearToDatePreviousYear
        {
            get { return Details.Sum(d => d.AmountYearToDatePreviousYear); }
        }
    }
}