using System.Collections.Generic;

namespace Xena.Contracts.Domain
{
    public class OrderTaskDto : EntityDto
    {
        private TotalsDto _totals;
        public TotalsDto Totals
        {
            get { return _totals ?? new TotalsDto(); }
            set { _totals = value; }
        }
        
        public string Abbreviation { get; set; }
        public long OrderId { get; set; }
        public long? SubscriptionId { get; set; }
        public bool PrintDetails { get; set; }
        public string Details { get; set; }
        public string Description { get; set; }
        public int Index { get; set; }
        public bool IsInvoiced { get; set; }
        public bool IsDelivered { get; set; }
        public bool IsConfirmed { get; set; }
        public bool IsReadonly { get; set; }
        public long OrderTaskStatusId { get; set; }
        public string OrderTaskStatusName { get; set; }
        public string OrderTaskStatusColor { get; set; }
        public long OrderNumber { get; set; }
    }
}
