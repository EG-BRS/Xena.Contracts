﻿using System.Collections.Generic;

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
        public long OrderId { get; set; }
        public long? SubscriptionId { get; set; }
        public bool PrintDetails { get; set; }
        public string Details { get; set; }
        public string Description { get; set; }
        public int Index { get; set; }
        public bool IsInvoiced { get; set; }
        public bool IsDelivered { get; set; }
        public bool IsConfirmed { get; set; }
        public bool IsReadonly
        {
            get { return IsInvoiced; }
        }
    }
}