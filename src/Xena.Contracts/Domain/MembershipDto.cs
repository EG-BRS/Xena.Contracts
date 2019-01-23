using System;
using System.ComponentModel;
using System.Linq;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class MembershipDto : IHasIdDto
    {
        public long? Id { get; set; }
        public long UserId { get; set; }
        public string Name { get; set; }
        public string Account { get; set; }
        public long? ResourceId { get; set; }
        public string ClientAccess { get; set; }
        public int ExpiresOnDays { get; set; }

        private string _clientAccessTranslated = null;
        [ReadOnly(true)]
        public string ClientAccessTranslated
        {
            get
            {
                return _clientAccessTranslated ?? (string.IsNullOrEmpty(ClientAccess)
                           ? string.Empty
                           : ClientAccess.GetLocalizedUserGroup());
            }
            set { _clientAccessTranslated = value; }
        }
        private string _securityGroups = null;
        [ReadOnly(true)]
        public string SecurityGroups
        {
            get
            {
                return _securityGroups ?? string.Join(", ",
                           _securityGroups.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                               .Select(sg => sg.GetLocalizedUserGroup()));
            }
            set { _securityGroups = value; }
        }
    }
}