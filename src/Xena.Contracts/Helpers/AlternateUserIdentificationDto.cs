using Xena.Contracts.Domain;


namespace Xena.Contracts.Helpers
{
    public class AlternateUserIdentificationDto : IHasIdDto, IHasUserIdDto
    {
        public string UserName { get; set; }
        public string IdentificationType { get; set; }
        public bool NotActivated { get; set; }
        public string ActivationLink { get; set; }

        public string IdentificationTypeTranslated
        { get; set; }

        public long? Id { get; set; }
        public long UserId { get; set; }
    }
}