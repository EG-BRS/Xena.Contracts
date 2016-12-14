using Xena.Contracts.Domain;

namespace Xena.Contracts.Helpers
{
    public class SettlementSuggestionDto
    {
        public PartnerPostDto PartnerPost { get; set; }
        public int Probability { get; set; }
    }
}