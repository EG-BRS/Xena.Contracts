namespace Xena.Contracts.Reports.FiscalBalance
{
    /// <summary>
    /// Ledgeraccount details - ArticleGroup-, Vat- and/or Tag specification
    /// </summary>
    public class FiscalBalanceDetailDataDto
    {
        public string Description { get; set; }
        public decimal AmountMonth { get; set; }
        public decimal AmountYearToDate { get; set; }
        public decimal AmountMonthPreviousYear { get; set; }
        public decimal AmountYearToDatePreviousYear { get; set; }
        public string Group { get; set; }
        public int GroupIndex { get; set; }
    }
}