using System;
using System.Linq;
using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class AccountantResourceDto : FiscalDto, IHasIdDto
    {
        public long? Id { get; set; }
        public long PartnerId { get; set; }
        public AddressDto Address { get; set; }
        public string SecurityGroup { get; set; }
        public string SecurityGroupTranslated
        {
            get { return string.IsNullOrEmpty(SecurityGroup) ? string.Empty : SecurityGroup.GetLocalizedUserGroup(); }
        }
        public long? AccountantDepartmentId { get; set; }  
        public string AccountantDepartmentDescription { get; set; }  
    }
}