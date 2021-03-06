using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class LedgerPostDraftDetailsDto
    {
        public long? LedgerPostDraftId { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public decimal CurrencyAmount { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public int FiscalDateDays { get; set; }
        private string _fiscalDateDaysFriendly;
        [ReadOnly(true)]
        public string FiscalDateDaysFriendly
        {
            get { return _fiscalDateDaysFriendly ?? FiscalDateDays.FriendlyString(); }
            set { _fiscalDateDaysFriendly = value; }
        }

        public override string ToString()
        {
            return $"{FiscalDateDaysFriendly} {Description}";
        }
    }
}