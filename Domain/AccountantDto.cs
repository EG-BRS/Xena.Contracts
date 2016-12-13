namespace Xena.Contracts.Domain
{
    public class AccountantDto : IHasIdDto
    {
        public long? Id { get; set; }
        public long? LogoId { get; set; }
        public string OrgNumber { get; set; }
        public AddressDto Address { get; set; }
    }

    public class XenaAccountantDepartmentDto : IHasIdDto
    {
        public long? Id { get; set; }
        public string Description { get; set; }
        public long AccountantId { get; set; }
    }
}