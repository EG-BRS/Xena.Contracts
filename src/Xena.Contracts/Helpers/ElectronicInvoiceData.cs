using System;

namespace Xena.Contracts.Helpers
{
    public class ElectronicInvoiceData
    {
        public long OrderInvoiceTransactionId { get; set; }
        [Obsolete("Use Endpoint instead")]
        public string RecipientAddressType { get; set; }
        [Obsolete("Use Endpoint instead")]
        public string RecipientAddress { get; set; }
        public string PartnerName { get; set; }
        public long PartnerId { get; set; }
        public int PartnerAccountNumber { get; set; }
        public int InvoiceNumber { get; set; }
        public string GLNNumber { get; set; }
        public string OrgNumber { get; set; }
        public InvoiceRecipientData Endpoint { get; set; }
        public InvoiceRecipientData PartyIdentification { get; set; }
    }
}