namespace Xena.Contracts.Domain
{
    public class PartnerDeliveryAddressDto : EntityDto
    {
        private bool? _isDefault;
        public long? PartnerDefaultDeliveryAddressId { get; set; }
        public long PartnerId { get; set; }

        public bool IsDefault
        {
            get { return _isDefault ?? Equals(Id, PartnerDefaultDeliveryAddressId); }
            set { _isDefault = value; }
        }

        public AddressDto Address { get; set; }
        public string Note { get; set; }
    }
}