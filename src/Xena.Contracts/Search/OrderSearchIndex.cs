using System.Collections.Generic;
using Xena.Contracts.Domain;

namespace Xena.Contracts.Search
{
    public class OrderSearchIndex
    {
        public long Id { get; set; }
        public long FiscalSetupId { get; set; }
        public bool IsDeactivated { get; set; }
        public string PartnerAccountNumber { get; set; }
        public string PartnerName { get; set; }
        public string PartnerPhoneNumber { get; set; }

        public string Name { get; set; }
        public string PlaceName { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string CountryName { get; set; }
        public string DeliveryName { get; set; }
        public string DeliveryPlaceName { get; set; }
        public string DeliveryStreet { get; set; }
        public string DeliveryZip { get; set; }
        public string DeliveryCity { get; set; }
        public string DeliveryCountryName { get; set; }
        public string OrderNumberSplits { get; set; }
        public string OurReference { get; set; }
        public string YourReference { get; set; }
        public IList<string> SupplierInvoiceNumbers { get; set; }
        public bool IsFullyDelivered { get; set; }
        public string ContextType { get; set; }
        public bool IsFullyInvoiced { get; set; }
        public long? OrderStatusId { get; set; }
        public long? PartnerId { get; set; }
        public long? ResponsibleId { get; set; }
    }
}