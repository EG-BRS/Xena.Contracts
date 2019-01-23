using System.ComponentModel;

namespace Xena.Contracts.Helpers
{
    public class OngoingOrderReportData
    {
        public long OrderId { get; set; }
        public int OrderNumber { get; set; }
        public long? PartnerId { get; set; }
        public string PartnerName { get; set; }
        public int? PartnerAccountNumber { get; set; }
        public long? ResponsibleId { get; set; }
        public string ResponsibleName { get; set; }
        public string InternalNote { get; set; }
        public decimal InvoicedTotal { get; set; }
        public decimal CostTotal { get; set; }
        private decimal? _margin = null;
        [ReadOnly(true)]
        public decimal Margin
        {
            get { return _margin ?? (InvoicedTotal - CostTotal); }
            set { _margin = value; }
        }
        private decimal? _marginPct = null;
        [ReadOnly(true)]
        public decimal MarginPct
        {
            get { return _marginPct ?? (InvoicedTotal == decimal.Zero ? decimal.Zero : Margin / InvoicedTotal * 100m); }
            set { _marginPct = value; }
        }
    }
}
