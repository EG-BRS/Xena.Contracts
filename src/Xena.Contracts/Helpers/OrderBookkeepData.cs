using System.Collections.Generic;
using Xena.Contracts.Domain;

namespace Xena.Contracts.Helpers
{
    public class OrderBookkeepData
    {
        public int Version { get; set; }
        public int? InvoicingDate { get; set; }
        public string SupplierInvoiceNumber { get; set; }
        public bool DoDeliver { get; set; }
        public long? InvoiceReportLayoutId { get; set; }
        public long? DeliveryReportLayoutId { get; set; }
        public IEnumerable<LedgerPostDraftDto> LedgerPostDrafts { get; set; }
        public long[] OrderTaskIds { get; set; }
        public long? OrderStatusId { get; set; }
    }
}