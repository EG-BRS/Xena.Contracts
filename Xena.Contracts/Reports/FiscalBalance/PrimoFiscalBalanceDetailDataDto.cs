namespace Xena.Contracts.Reports.FiscalBalance
{
    /// <summary>
    /// Ledgeraccount details - ArticleGroup-, Vat- and/or Tag specification
    /// </summary>
    public class PrimoFiscalBalanceDetailDataDto
    {
        public string Description { get; set; }
        public decimal AmountPrimo { get; set; }
    }
}