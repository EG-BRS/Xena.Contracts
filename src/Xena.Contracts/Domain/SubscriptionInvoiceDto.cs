using System;
using System.ComponentModel;
using Xena.Common.ExtensionMethods;
using Xena.Common.Constants;

namespace Xena.Contracts.Domain
{
    public class SubscriptionInvoiceDto : IHasIdDto
    {
        public long? Id { get; set; }
        public int? InvoicingDateDays { get; set; }
        public long SubscriptionId { get; set; }
        public int OrderNumber { get; set; }
        public long? OrderInvoiceTransactionId { get; set; }
        public long? SettlementId { get; set; }

        private string _invoicingDateDaysFriendly = null;
        [ReadOnly(true)]
        public string InvoicingDateDaysFriendly
        {
            get { return _invoicingDateDaysFriendly ?? (InvoicingDateDays.HasValue ? InvoicingDateDays.Value.FriendlyString() : string.Empty); }
            set { _invoicingDateDaysFriendly = value; }
        }
        public long? OrderJournalEntryId { get; set; }
        public int? InvoiceNumber { get; set; }
        public decimal? PriceNettTotal { get; set; }
        public long OrderId { get; set; }

        private string _state = null;
        [ReadOnly(true)]
        public string State
        {
            get
            {
                if (_state != null)
                {
                    return _state;
                }

                if (SettlementId.HasValue)
                    return SubscriptionInvoiceStates.Paid;
                return OrderInvoiceTransactionId.HasValue
                    ? SubscriptionInvoiceStates.Invoiced
                    : SubscriptionInvoiceStates.Open;
            }
            set { _state = value; }
        }
        private string _stateFriendly = null;
        [ReadOnly(true)]
        public string StateFriendly
        {
            get { return _stateFriendly ?? State.GetLocalizedConstant(); }
            set { _stateFriendly = value; }
        }
        public long FiscalSetupId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}