namespace Xena.Contracts.Domain
{
    public class AccountantResourceTempAccessDto : FiscalDto, IHasIdDto
    {
        public long AccountantId { get; set; }
        public long ClientId { get; set; }
        public long? Id { get; set; }
        //Convinience properties
        public string AccountantName { get; protected set; }
        public string ClientName { get; protected set; }
    }
}