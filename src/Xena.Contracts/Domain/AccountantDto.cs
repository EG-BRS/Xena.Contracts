namespace Xena.Contracts.Domain
{
    public class AccountantDto : IHasIdDto
    {
        public long? Id { get; set; }
        public long? LogoId { get; set; }
        public string OrgNumber { get; set; }
        public AddressDto Address { get; set; }
    }
}