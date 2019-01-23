using System.ComponentModel;

namespace Xena.Contracts.Reports.WorkInProgress
{
    public class WorkInProgressDetailData
    {
        public long ProjectId { get; set; }
        public int ProjectNumber { get; set; }
        public string ProjectDescription { get; set; }
        public long? PartnerId { get; set; }
        public string PartnerName { get; set; }
        public int? PartnerAccountNumber { get; set; }
        public string ProjectGroupDescription { get; set; }
        public long? ResponsibleId { get; set; }
        public string ResponsibleName { get; set; }
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
            get { return _marginPct ?? (InvoicedTotal == decimal.Zero? decimal.Zero : Margin / InvoicedTotal* 100m); }
            set { _marginPct = value; }
        }
        public decimal BudgetTotal { get; set; }
        private decimal? _difference = null;
        [ReadOnly(true)]
        public decimal Difference
        {
            get { return _difference ?? (InvoicedTotal - BudgetTotal); }
            set { _difference = value; }
        }
    }
}