namespace Xena.Contracts.Domain
{
    public class XenaUserResourceDto : XenaUserDto
    {
        public string Name { get; set; }
    }

    public class XenaBookkeepingAccessDto : FiscalDto, IHasIdDto
    {
        public long? Id { get; set; }
        public long? LedgerId { get; set; }
        public bool IsAccountant { get; set; }
        public bool CanBookkeep { get; set; }
    }
}