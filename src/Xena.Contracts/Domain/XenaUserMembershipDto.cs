using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class MenuFiscal
    {
        public string FiscalSetupName { get; set; }
        public long? VCardId { get; set; }
        public long? PictureLastVersionId { get; set; }

        private string _pictureUrl;
        [ReadOnly(true)]
        public string PictureUrl
        {
            get => _pictureUrl ?? (PictureLastVersionId.HasValue && VCardId.HasValue
                    ? $"/Api/Blob/Public/VCard/{VCardId}/Thumbnail/{PictureLastVersionId}"
                    : "/Content/images/avatar-company-xena.jpg");
            set => _pictureUrl = value;
        }
    }

    public class IdSResourceDto : IHasIdDto
    {
        public long? Id { get; set; }
        public long UserId { get; set; }
        public long FiscalSetupId { get; set; }
    }
    public class IdSMembershipDto 
    {
        public long? Id { get; set; }
        public long FiscalSetupId { get; set; }
        public long UserId { get; set; }
        public long? ResourceId { get; set; }
        public string FiscalSetupName { get; set; }
        public string PictureUrl { get; set; }
        public string SecurityGroups { get; set; }
    }
    public class XenaUserMembershipDto : IHasIdDto
    {
        private string _securityGroupsRaw;

        protected XenaUserMembershipDto()
        {
        }
        public XenaUserMembershipDto(string securityGroupsRaw)
        {
            _securityGroupsRaw = securityGroupsRaw;
        }

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

        private string _pictureUrl;
        [ReadOnly(true)]
        public string PictureUrl
        {
            get => _pictureUrl ?? (PictureLastVersionId.HasValue && VCardId.HasValue
                    ? $"/Api/Blob/Public/VCard/{VCardId}/Thumbnail/{PictureLastVersionId}"
                    : "/Content/images/avatar-company-xena.jpg");
            set => _pictureUrl = value;
        }

        private string _securityGroups = null;
        [ReadOnly(true)]
        public string SecurityGroups
        {
            get { return _securityGroups ?? string.Join(", ", SecurityGroupsRaw().Select(sg => sg.GetLocalizedUserGroup())); }
            set { _securityGroups = value; }
        }

        public IEnumerable<string> SecurityGroupsRaw()
        {
            return _securityGroupsRaw.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }

    }
}