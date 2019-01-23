using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Xena.Contracts.Domain
{
    public class BankPostingDto : FiscalDto, IHasIdDto
    {
        public long? Id { get; set; }
        public long BankContextId { get; set; }
        public int FiscalDateDays { get; set; }
        [Required]
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public decimal Saldo { get; set; }

        [ReadOnly(true)]
        public long? BankSettlementId { get; set; }

        //Convinience properties
        [ReadOnly(true)]
        public int SuggestionCount { get; set; }
        [ReadOnly(true)]
        public decimal? HighestProbability { get; set; }
    }
}