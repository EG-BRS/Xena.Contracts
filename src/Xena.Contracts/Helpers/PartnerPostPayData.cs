using Xena.Contracts.Domain;

namespace Xena.Contracts.Helpers
{
    public class PartnerPostPayData
    {
        public LedgerPostDraftDto[] LedgerPosts { get; set; }
        public long[] PartnerPostIds { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public int? PayDate { get; set; }
        public long PartialSettleId { get; set; }
    }
}