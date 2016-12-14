namespace Xena.Contracts.Domain
{
    public class PartnerTelephoneNumberDto : EntityDto
    {
        public long PartnerId { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public bool SMS { get; set; }
    }
}