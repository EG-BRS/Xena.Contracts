namespace Xena.Contracts.Domain
{
    public class BankPostingDto : FiscalDto, IHasIdDto
    {
        public long? Id { get; set; }
        public long BankContextId { get; set; }
        public int FiscalDateDays { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public decimal Saldo { get; set; }
        public long? BankSettlementId { get; set; }
        public int SuggestionCount { get; set; }
        public decimal? HighestProbability { get; set; }
    }
}