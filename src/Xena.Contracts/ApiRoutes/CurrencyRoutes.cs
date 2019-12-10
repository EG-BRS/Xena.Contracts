namespace Xena.Contracts.ApiRoutes
{
    public class CurrencyRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/Currency"</summary>
        public const string Base = "Fiscal/{fiscalId}/Currency";

        /// <summary>""</summary>
        public const string GetList = "";

        /// <summary>"{currencyAbbreviation}/ExchangeRateByDate"</summary>
        public const string GetExchangeRate = "{currencyAbbreviation}/ExchangeRateByDate";

        /// <summary>"{currencyAbbreviation}/CurrencyAmountToPay"</summary>
        public const string GetCurrencyAmountToPay = "{currencyAbbreviation}/CurrencyAmountToPay";

        /// <summary>"/Abbreviation"</summary>
        public const string GetAbbreviations = "Abbreviations";
    }
}