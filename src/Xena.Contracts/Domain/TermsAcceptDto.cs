namespace Xena.Contracts.Domain
{
    public class TermsAcceptDto : EntityDto
    {
        public long TermsCultureId { get; set; }
        public long ReferenceUserId { get; set; }
        public long? ReferenceFiscalSetupId { get; set; }
    }
}