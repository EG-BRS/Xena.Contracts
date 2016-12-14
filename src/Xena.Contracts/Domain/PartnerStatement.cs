namespace Xena.Contracts.Domain
{
    public class PartnerStatement
    {
        public long? Id { get; set; }
        public string PostType { get; set; }
        public decimal Amount { get; set; }
        public decimal CurrencyAmount { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public int FiscalDate { get; set; }
        public decimal Saldo { get; set; }
        public long? OrderJournalId { get; set; }
        public int InvoiceNumber { get; set; }
    }
}