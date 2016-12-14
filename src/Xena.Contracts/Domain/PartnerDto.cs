using System.Collections.Generic;
using System.Threading;


namespace Xena.Contracts.Domain
{
    public class PartnerDto : EntityDto
    {
        public PartnerDto()
        {
            Tags = new List<string>();
        }
        public int? AccountNumber { get; set; }
        public AddressDto Address { get; set; }
        public long? ReferenceFiscalSetupId { get; set; }
        public long? ReferenceUserId { get; set; }
        public string Attention { get; set; }
        public string PartnerType { get; set; }
        public string PartnerTypeTranslated
        { get; set; }
        public string PhoneNumber { get; set; }
        public string Note { get; set; }
        public string URL { get; set; }
        public string GLNNumber { get; set; }
        public string OrgNumber { get; set; }
        public long? SupplierId { get; set; }
        public long? CustomerId { get; set; }
        public long? ResourceId { get; set; }
        public long? DefaultDeliveryAddressId { get; set; }

        public string ShortDescription
        { get; set; }

        public string LongDescription
        { get; set; }
        public IList<string> Tags { get; set; }
    }
}