namespace Xena.Contracts.Domain
{
    public class PartnerEmailContactDto : EntityDto
    {
        public long PartnerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}