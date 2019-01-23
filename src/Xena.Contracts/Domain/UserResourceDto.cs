namespace Xena.Contracts.Domain
{
    public class UserResourceDto : IHasIdDto
    {
        public long? Id { get; set; }
        public long FiscalSetupId { get; set; }
        public long? UserId { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public string Theme { get; set; }
    }
}