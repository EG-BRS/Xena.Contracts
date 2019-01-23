using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class OrderInvoiceDto
    {
        public long OrderId { get; set; }
        public int OrderNumber { get; set; }
        public int InvoiceNumber { get; set; }
        public long PayerId { get; set; }
        public int InvoicingDateDays { get; set; }
        private string _invoicingDateDaysFriendly = null;
        [ReadOnly(true)]
        public string InvoicingDateDaysFriendly
        {
            get { return _invoicingDateDaysFriendly ?? InvoicingDateDays.FriendlyString(); }
            set { _invoicingDateDaysFriendly = value; }
        }
        public string ContextType { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public IList<OrderInvoiceTaskDto> OrderTasks { get; set; }
        public bool IsExcemptFromVAT { get; set; }
        public TotalsDto Totals { get; set; }
        public int DueDateDays { get; set; }
        private string _dueDateDaysFriendly = null;
        [ReadOnly(true)]
        public string DueDateDaysFriendly
        {
            get { return _dueDateDaysFriendly ?? DueDateDays.FriendlyString(); }
            set { _dueDateDaysFriendly = value; }
        }
        public DateTime InvoiceTimeLocal { get; set; }
        public IEnumerable<VatTotalsDto> VatTotals { get; set; }
    }
}