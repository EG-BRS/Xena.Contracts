using Xena.Resources;
using Xena.Resources.Constants;

namespace Xena.Contracts.Domain
{
    public class SubscriptionInvoiceDto : FiscalDto, IHasIdDto
    {
        public long? Id { get; set; }
        public long OrderId { get; set; }
        public long SubscriptionId { get; set; }
        public int OrderNumber { get; set; }
        public int? InvoiceNumber { get; set; }
        public long? OrderInvoiceTransactionId { get; set; }
        public long? OrderJournalEntryId { get; set; }
        public long? SettlementId { get; set; }
        public decimal? PriceNettTotal { get; set; }
        public int? InvoicingDateDays { get; set; }

        public string InvoicingDateDaysFriendly
        {
            get { return InvoicingDateDays.HasValue ? InvoicingDateDays.Value.FriendlyString() : string.Empty; }
        }

        public string State
        {
            get
            {
                if (SettlementId.HasValue)
                    return SubscriptionInvoiceStates.Paid;
                return OrderInvoiceTransactionId.HasValue 
                    ? SubscriptionInvoiceStates.Invoiced 
                    : SubscriptionInvoiceStates.Open;
            }
        }
        public string StateFriendly
        {
            get { return State.GetLocalizedConstant(); }
        }
    }
}