using System.Collections.Generic;
using System.ComponentModel;

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
        public int? AccountNumber { get; set; }
        public string AccountDescription { get; set; }
        private string _description = null;
        [ReadOnly(true)]
        public string Description
        {
            get
            {
                return _description ??
                       (AccountNumber.HasValue ? $"{AccountNumber} {AccountDescription}" : AccountDescription);
            }
            set { _description = value; }
        }
        public decimal AmountMonth { get; set; }
        public decimal AmountYearToDate { get; set; }
        public decimal AmountMonthPreviousYear { get; set; }
        public decimal AmountYearToDatePreviousYear { get; set; }
        public string TranslatedGroup { get; set; }
        public IList<FiscalBalanceDetailDataDto> Details { get; set; }
        public IList<FiscalBalanceDetailGroupData> GroupedDetails { get; set; }
    }
}