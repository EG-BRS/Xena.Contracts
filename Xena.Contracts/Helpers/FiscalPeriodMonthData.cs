using System.Collections.Generic;
using Xena.Contracts.Domain;

namespace Xena.Contracts.Helpers
{
    public class FiscalPeriodMonthData
    {
        public FiscalPeriodMonthData()
        {
            FiscalPeriods = new List<object>();
            Months = new List<MonthDto>();
        }
        public string CurrencyDescription { get; set; }
        public long FiscalPeriodId { get; set; }
        public IEnumerable<object> FiscalPeriods { get; set; }
        public IEnumerable<MonthDto> Months { get; set; }
        public bool SimpleSetting { get; set; }
    }

}