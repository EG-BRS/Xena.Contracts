using System;
using System.Collections.Generic;
using System.Linq;
using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class MenuFiscal
    {
        public string FiscalSetupName { get; set; }
        public long? VCardId { get; set; }
        public long? PictureLastVersionId { get; set; }
        public string PictureUrl => PictureLastVersionId.HasValue && VCardId.HasValue
            ? $"/Blob/Public/VCard/{VCardId}/{PictureLastVersionId}/MenuThumbnail"
            : "/Content/images/avatar-company-xena.jpg";

    }
    public class XenaUserMembershipDto : IHasIdDto
    {
        private string _securityGroups;
        public long? Id { get; set; }
        public long MembershipId { get; set; }
        public long FiscalSetupId { get; set; }
        public long UserId { get; set; }
        public long? ResourceId { get; set; }
        public string ResourceName { get; set; }
        public string ResourceTheme { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public string FiscalSetupName { get; set; }
        public long? VCardId { get; set; }
        public long? XenaSubscriptionId { get; set; }
        public string SproomKey { get; set; }
        public long? PictureLastVersionId { get; set; }

        public string PictureUrl => PictureLastVersionId.HasValue && VCardId.HasValue
            ? $"/Blob/Public/VCard/{VCardId}/{PictureLastVersionId}/MenuThumbnail"
            : "/Content/images/avatar-company-xena.jpg";

        public string SecurityGroups
        {
            get { return string.Join(", ", SecurityGroupsRaw().Select(sg => sg.GetLocalizedUserGroup())); }
        }

        public IEnumerable<string> SecurityGroupsRaw()
        {
            return _securityGroups.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

    }
}