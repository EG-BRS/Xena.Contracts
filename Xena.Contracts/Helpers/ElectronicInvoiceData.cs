namespace Xena.Contracts.Helpers
{
    public class ElectronicInvoiceData
    {
        public long OrderInvoiceTransactionId { get; set; }
        public string RecipientAddressType { get; set; }
        public string RecipientAddress { get; set; }
        public string PartnerName { get; set; }
        public int PartnerAccountNumber { get; set; }
        public int InvoiceNumber { get; set; }
        public string GLNNumber { get; set; }
        public string OrgNumber { get; set; }
    }
}