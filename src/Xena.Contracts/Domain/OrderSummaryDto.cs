namespace Xena.Contracts.Domain
{
    public class OrderSummaryDto
    {
        private TotalsDto _totals;
        private TotalsDto _notInvoicedTotals;

        public TotalsDto Totals
        {
            get { return _totals??new TotalsDto(); }
            set { _totals = value; }
        }

        public TotalsDto NotInvoicedTotals
        {
            get { return _notInvoicedTotals??new TotalsDto(); }
            set { _notInvoicedTotals = value; }
        }

        public bool IsFullyInvoiced { get; set; }
        public bool IsFullyDelivered { get; set; }
        public bool IsFullyConfirmed { get; set; }
        public bool CanOffer { get; set; }
        public bool CanDeliver { get; set; }
        public bool CanInvoice { get; set; }
        public bool CanPay { get; set; }
        public bool CanConfirm { get; set; }
    }
}