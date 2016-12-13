using System.Collections.Generic;

namespace Xena.Contracts.Domain
{
    public class OrderInvoiceTaskDto : IHasIdDto
    {
        public long? Id { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public bool PrintDetails { get; set; }
        public long TransactionId { get; set; }
        public IList<OrderLineDto> OrderLines { get; set; }
        public int Index { get; set; }
        public TotalsDto Totals { get; set; }
    }
}