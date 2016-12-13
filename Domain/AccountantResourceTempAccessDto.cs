namespace Xena.Contracts.Domain
{
    public class AccountantResourceTempAccessDto : FiscalDto, IHasIdDto
    {
        public long AccountantId { get; set; }
        public string AccountantName { get; set; }
        public string ClientName { get; set; }
        public long ClientId { get; set; }
        public long? Id { get; set; }
    }
}