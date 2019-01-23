using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class AccountantResourceDto : FiscalDto, IHasIdDto
    {
        public long? Id { get; set; }
        public long PartnerId { get; set; }
        public AddressDto Address { get; set; }
        public string SecurityGroup { get; set; }
        public long? AccountantDepartmentId { get; set; }
        //Convinience properties
        private string _securityGroupTranslated = null;
        [ReadOnly(true)]
        public string SecurityGroupTranslated
        {
            get
            {
                return _securityGroupTranslated ?? (string.IsNullOrEmpty(SecurityGroup)
                           ? string.Empty
                           : SecurityGroup.GetLocalizedUserGroup());
            }
            set { _securityGroupTranslated = value; }
        }

        [ReadOnly(true)]
        public string AccountantDepartmentDescription { get;  set; }  
    }
}