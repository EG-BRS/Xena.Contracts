using System;
using System.Linq;


namespace Xena.Contracts.Domain
{
    public class MembershipDto : IHasIdDto
    {
        private string _securityGroups;
        public long? Id { get; set; }
        public string Name { get; set; }
        public string Account { get; set; }
        public long? ResourceId { get; set; }
        public string ClientAccess { get; set; }
        public int ExpiresOnDays { get; set; }

        public string ClientAccessTranslated { get; set; }
        public string SecurityGroups { get; set; }
        public string UserId { get; set; }
    }
}