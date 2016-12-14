

namespace Xena.Contracts.Domain
{
    public class SettledPartnerPostDto:IHasIdDto
    {
        public long? Id { get; set; }
        public int VoucherNumber { get; set; }
        public string PostType { get; set; }
        public string PostTypeTranslated
        { get; set; }
    }
}