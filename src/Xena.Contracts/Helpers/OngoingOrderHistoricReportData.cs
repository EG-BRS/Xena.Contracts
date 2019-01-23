using System.Collections.Generic;

namespace Xena.Contracts.Helpers
{
    public class OngoingOrderHistoricReportData
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
        public decimal OngoingEstimatedInvoiceTotal { get; set; }
        public decimal OngoingCostTotal { get; set; }
        public List<OngoingOrderTaskHistoricData> Tasks { get; set; }
    }
}