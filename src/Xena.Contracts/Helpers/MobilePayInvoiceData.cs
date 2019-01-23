namespace Xena.Contracts.Helpers
{
    public class MobilePayInvoiceData
    {
        public long OrderInvoiceTransactionId { get; set; }
        public int InvoiceNumber { get; set; }
        public string TelephoneNumber { get; set; }
        public string PartnerName { get; set; }
        public int PartnerAccountNumber { get; set; }
    }
}