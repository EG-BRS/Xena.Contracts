using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class CurrencyExchangeRateDto : EntityDto
    {
        public int EffectiveFromDays { get; set; }
        [Required]
        [Range(0,99999999)]
        public decimal ExchangeRate { get; set; }
        [Required]
        public string CurrencyAbbreviation { get; set; }
        
        //Convinience properties
        private string _currencyDescription = null;
        [ReadOnly(true)]
        public string CurrencyDescription
        {
            get { return _currencyDescription ?? CurrencyAbbreviation.GetLocalizedCurrencyName(); }
            set { _currencyDescription = value; }
        }

        private string _effectiveFromDaysFriendly;

        [ReadOnly(true)]
        public string EffectiveFromDaysFriendly
        {
            get { return _effectiveFromDaysFriendly ?? EffectiveFromDays.FriendlyString(); }
            set { _effectiveFromDaysFriendly = value; }
        }
    }
}