using System.ComponentModel;

namespace Xena.Contracts.Reports.FiscalBalance
{
    /// <summary>
    /// Ledgeraccount details - ArticleGroup-, Vat- and/or Tag specification
    /// </summary>
    public class FiscalBalanceDetailDataDto
    {
        public int? AccountNumber { get; set; }
        public string AccountDescription { get; set; }
        private string _description = null;
        [ReadOnly(true)]
        public string Description
        {
            get { return _description ?? (AccountNumber.HasValue ? $"{AccountNumber} {AccountDescription}" : AccountDescription); }
            set { _description = value; }
        }
        public decimal AmountMonth { get; set; }
        public decimal AmountYearToDate { get; set; }
        public decimal AmountMonthPreviousYear { get; set; }
        public decimal AmountYearToDatePreviousYear { get; set; }
        public string Group { get; set; }
        public int GroupIndex { get; set; }
    }
}