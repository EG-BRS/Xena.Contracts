using System.ComponentModel;

namespace Xena.Contracts.Domain
{
    public class AccountantResourceTempAccessDto : FiscalDto, IHasIdDto
    {
        public long AccountantId { get; set; }
        public long ClientId { get; set; }
        public long? Id { get; set; }
        //Convinience properties
        [ReadOnly(true)]
        public string AccountantName { get; set; }
        [ReadOnly(true)]
        public string ClientName { get; set; }
    }
}