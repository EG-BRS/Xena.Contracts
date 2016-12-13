using System.Collections.Generic;
using Xena.Contracts.Domain;

namespace Xena.Contracts.Helpers
{
    public class CancelInvoiceData
    {
        public bool DoReturn { get; set; }
        public int? ReturnDate { get; set; }
        public long? InvoiceLayoutId { get; set; }
        public long? ReturnLayoutId { get; set; }
        public IEnumerable<LedgerPostDraftDto> LedgerPostDrafts { get; set; }
        public string SupplierInvoiceNumber { get; set; }
    }
}