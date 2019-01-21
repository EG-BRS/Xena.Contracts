using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class LedgerPostDetailsDto
    {
        public long? LedgerPostId { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public decimal CurrencyAmount { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public int FiscalDateDays { get; set; }

        private string _fiscalDateFriendly;
        [ReadOnly(true)]
        public string FiscalDateDaysFriendly
        {
            get { return _fiscalDateFriendly   ?? FiscalDateDays.FriendlyString(); }
            set { _fiscalDateFriendly = value; }
        }

        public override string ToString()
        {
            return $"{FiscalDateDaysFriendly} {Description}";
        }
    }
}