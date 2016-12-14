using System;
using System.Linq;


namespace Xena.Contracts.Domain
{
    public class AccountantResourceDto : FiscalDto, IHasIdDto
    {
        public long? Id { get; set; }
        public long PartnerId { get; set; }
        public AddressDto Address { get; set; }
        public string SecurityGroup { get; set; }
        public string SecurityGroupTranslated
        { get; set; }
        public long? AccountantDepartmentId { get; set; }  
        public string AccountantDepartmentDescription { get; set; }  
    }
}