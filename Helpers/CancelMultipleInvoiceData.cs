using System.Collections.Generic;
using Xena.Contracts.Domain;

namespace Xena.Contracts.Helpers
{
    public class CancelMultipleInvoiceData
    {
        public CancelOrderInvoiceTransaction[] OrderInvoiceTransactions { get; set; }
        public long? InvoiceReportLayoutId { get; set; }
        public long? DeliveryReportLayoutId { get; set; }
        public IEnumerable<LedgerPostDraftDto> LedgerPostDrafts { get; set; }
        public string SupplierInvoiceNumber { get; set; }

        public class CancelOrderInvoiceTransaction
        {
            public long Id { get; set; }
            public bool DoReturn { get; set; }
        }
    }
}