

namespace Xena.Contracts.Domain
{
    public class CurrencyExchangeRateDto : EntityDto
    {
        public int EffectiveFromDays { get; set; }
        public string EffectiveFromDaysFriendly
        { get; set; }
        public decimal ExchangeRate { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public string CurrencyDescription
        { get; set; }
    }
}