namespace Xena.Contracts.Domain
{
    public class XenaUserDto
    {
        public long Id { get; set; }
        public long ReferenceUserId { get; set; }
        public bool IsDeactivated { get; set; }
        public long FiscalSetupId { get; set; }
    }
}