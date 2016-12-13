using System.Collections.Generic;

namespace Xena.Contracts.Helpers
{
    public class MembershipData
    {
        public long? MembershipId { get; set; }
        public IEnumerable<string> SecurityGroup { get; set; }
        public bool UserAllowedToChangeRoles { get; set; }
    }
}