using System.ComponentModel;

namespace Xena.Contracts.Domain
{
    public class AccountantClientDto : FiscalDto,IHasIdDto
    {
        public long? Id { get; set; }
        public AddressDto Address { get; set; }
        public string Attention { get; set; }
        public string PhoneNumber { get; set; }
        public string OrgNumber { get; set; }
        public int NoAccountants { get; set; }
        public long? PartnerId { get; set; }
        public long ReferenceFiscalSetupId { get; set; }
        public long? AccountantDepartmentId { get; set; }

        //Convinience properties
        [ReadOnly(true)]
        public int? AccountNumber { get; set; }
        [ReadOnly(true)]
        public string AccountantDepartmentDescription { get; set; }
    }
}