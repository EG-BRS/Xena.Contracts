using Xena.Contracts.Domain;
using Xena.Resources;

namespace Xena.Contracts.Helpers
{
    public class AlternateUserIdentificationDto : IHasIdDto, IHasUserIdDto
    {
        public string UserName { get; set; }
        public string IdentificationType { get; set; }
        public bool NotActivated { get; set; }
        public string ActivationLink { get; set; }

        public string IdentificationTypeTranslated
        {
            get { return IdentificationType.GetLocalizedIdentityType(); }
        }

        public long? Id { get; set; }
        public long UserId { get; set; }
    }
}