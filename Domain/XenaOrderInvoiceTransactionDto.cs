namespace Xena.Contracts.Domain
{
    public class XenaOrderInvoiceTransactionDto:IHasIdDto
    {
        public long? Id { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public decimal VatEstTotal { get; set; }
        public decimal PriceNettTotal { get; set; }
    }
}