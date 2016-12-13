using System;
using System.Linq;
using Xena.Resources;

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

        public string ClientAccessTranslated => string.IsNullOrEmpty(ClientAccess) ? string.Empty : ClientAccess.GetLocalizedUserGroup();
        public string SecurityGroups => _securityGroups == null ? string.Empty : string.Join(", ", _securityGroups.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(sg => sg.GetLocalizedUserGroup()));
    }
}