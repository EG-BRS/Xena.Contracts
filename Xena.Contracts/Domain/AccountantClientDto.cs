namespace Xena.Contracts.Domain
{
    public class AccountantClientDto : FiscalDto,IHasIdDto
    {
        public int? AccountNumber { get; set; }
        public AddressDto Address { get; set; }
        public string Attention { get; set; }
        public string PhoneNumber { get; set; }
        public string OrgNumber { get; set; }
        public int NoAccountants { get; set; }
        public long? PartnerId { get; set; }
        public long ReferenceFiscalSetupId { get; set; }
        public long? AccountantDepartmentId { get; set; }
        public string AccountantDepartmentDescription { get; set; }
        public long? Id { get; set; }
    }
}