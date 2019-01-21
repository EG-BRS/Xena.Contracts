using System.ComponentModel;
using Xena.Common.ExtensionMethods;
using Xena.Contracts.Domain;

namespace Xena.Contracts.Helpers
{
    public class UnpaidStockDetailDto : FiscalDto, IHasIdDto
    {
        public long? Id { get; set; }
        public int OrderNumber { get; set; }
        public decimal LedgerPostAmountTotal { get; set; }
        public bool IsFullyDelivered { get; set; }
        public bool IsFullyInvoiced { get; set; }
        public int? FirstDeliveryDateDays { get; set; }
        private string _firstDeliveryDateDaysFriendly = null;
        [ReadOnly(true)]
        public string FirstDeliveryDateDaysFriendly
        {
            get
            {
                return _firstDeliveryDateDaysFriendly ?? (FirstDeliveryDateDays.HasValue
                           ? FirstDeliveryDateDays.Value.FriendlyString()
                           : string.Empty);
            }
            set { _firstDeliveryDateDaysFriendly = value; }
        }
        public int? FirstInvoiceDateDays { get; set; }
        private string _firstInvoiceDateDaysFriendly = null;
        [ReadOnly(true)]
        public string FirstInvoiceDateDaysFriendly
        {
            get
            {
                return _firstInvoiceDateDaysFriendly ?? (FirstInvoiceDateDays.HasValue ? FirstInvoiceDateDays.Value.FriendlyString() : string.Empty);
            }
            set { _firstInvoiceDateDaysFriendly = value; }
        }
    }
}