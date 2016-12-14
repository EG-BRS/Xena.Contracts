using System.Collections.Generic;

namespace Xena.Contracts.Helpers
{
    public class OrderReportData
    {
        public IEnumerable<object> InvoiceReports { get; set; }
        public IEnumerable<object> DeliveryReports { get; set; }
        public IEnumerable<object> OfferLayouts { get; set; }
        public IEnumerable<object> ConfirmationLayouts { get; set; }
    }
}