using System;
using System.Collections.Generic;


namespace Xena.Contracts.Domain
{
    public class OrderInvoiceDto
    {
        public long OrderId { get; set; }
        public int OrderNumber { get; set; }
        public int InvoiceNumber { get; set; }
        public long PayerId { get; set; }
        public int InvoicingDateDays { get; set; }
        public string InvoicingDateDaysFriendly
        { get; set; }
        public string ContextType { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public IList<OrderInvoiceTaskDto> OrderTasks { get; set; }
        public bool IsExcemptFromVAT { get; set; }
        public TotalsDto Totals { get; set; }
        public int DueDateDays { get; set; }
        public string DueDateDaysFriendly
        { get; set; }
        public DateTime InvoiceTimeLocal { get; set; }
        public IEnumerable<VatTotalsDto> VatTotals { get; set; }
    }
}