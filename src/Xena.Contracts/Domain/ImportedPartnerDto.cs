using System.Collections.Generic;

namespace Xena.Contracts.Domain
{
    public class ImportedPartnerDto : ImportedDto
    {
        public string OriginalId { get; set; }
        public AddressDto Address { get; set; }
        public string ContactNo { get; set; }
        public string EAN { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string VATNo { get; set; }
        public long? MappedPartnerId { get; set; }
        public string MappedPartnerName { get; set; }
        public int? MappedPartnerAccountNumber { get; set; }
    }
}