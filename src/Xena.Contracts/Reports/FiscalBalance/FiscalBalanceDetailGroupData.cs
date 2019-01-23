using System.Collections.Generic;
using System.ComponentModel;
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
        private decimal? _amountMonth = null;
        [ReadOnly(true)]
        public decimal AmountMonth
        {
            get { return _amountMonth ?? Details.Sum(d => d.AmountMonth); }
            set { _amountMonth = value; }
        }
        private decimal? _amountYearToDate = null;
        [ReadOnly(true)]
        public decimal AmountYearToDate
        {
            get { return _amountYearToDate ?? Details.Sum(d => d.AmountYearToDate); }
            set { _amountYearToDate = value; }
        }
        private decimal? _amountMonthPreviousYear = null;
        [ReadOnly(true)]
        public decimal AmountMonthPreviousYear
        {
            get { return _amountMonthPreviousYear ?? Details.Sum(d => d.AmountMonthPreviousYear); }
            set { _amountMonthPreviousYear = value; }
        }
        private decimal? _amountYearToDatePreviousYear = null;
        [ReadOnly(true)]
        public decimal AmountYearToDatePreviousYear
        {
            get { return _amountYearToDatePreviousYear ?? Details.Sum(d => d.AmountYearToDatePreviousYear); }
            set { _amountYearToDatePreviousYear = value; }
        }
    }
}