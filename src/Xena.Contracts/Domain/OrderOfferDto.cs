using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class OrderOfferDto : TransactionalDto
    {
        public TotalsDto Totals { get; set; }
        public long? OrderId { get; set; }
        public AddressDto OrderAddress { get; set; }
        public AddressDto OrderDeliveryAddress { get; set; }
        public int OfferDateDays { get; set; }
        public long ReportLayoutId { get; set; }
        public string OfferNumber { get; set; }
        public long? JournalId { get; set; }
        public long? PartnerId { get; set; }
        public string PartnerName { get; set; }
        public long? ResponsibleId { get; set; }
        public string ResponsibleName { get; set; }
        public int? PartnerAccountNumber { get; set; }
        private string _offerDateDaysFriendly = null;
        [ReadOnly(true)]
        public string OfferDateDaysFriendly
        {
            get { return _offerDateDaysFriendly ?? OfferDateDays.FriendlyString(); }
            set { _offerDateDaysFriendly = value; }
        }
    }
}