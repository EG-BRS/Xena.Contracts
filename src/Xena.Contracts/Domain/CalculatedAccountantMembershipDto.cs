using System;
using System.Collections.Generic;
using System.Linq;


namespace Xena.Contracts.Domain
{
    public class CalculatedAccountantMembershipDto : IHasIdDto
    {
        public long? Id { get; set; }
        public long MembershipId { get; set; }
        public long FiscalSetupId { get; set; }
        public long UserId { get; set; }
        public long? ResourceId { get; set; }
        public string ResourceName { get; set; }
        public string ResourceTheme { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public long? XenaSubscriptionId { get; set; }
        public string FiscalSetupType { get; set; }
        public string SproomKey { get; set; }
        public string SecurityGroups { get; set; }
    }
}