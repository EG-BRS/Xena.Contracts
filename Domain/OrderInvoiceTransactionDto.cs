namespace Xena.Contracts.Domain
{
    public class OrderInvoiceTransactionDto:TransactionalDto
    {
        public long EconomicTransactionId { get; set; }
        public OrderInvoiceDto OrderInvoice { get; set; }
    }
}