using Xena.Contracts.Domain;

namespace Xena.Contracts.Helpers
{
    public class XenaDiscountCodeDto : IHasIdDto
    {
        public long? Id { get; set; }
        public long ProviderId { get; set; }
        public string Code { get; set; }
        public int ExpirationDateDays { get; set; }
    }
}