namespace Xena.Contracts.ApiRoutes
{
    public class CurrencyExchangeRateRoutes : BaseRoutes
    {
        /// <summary>"Api/Fiscal/{fiscalId}/CurrencyExchangeRate"</summary>
        public const string Base = "Api/Fiscal/{fiscalId}/CurrencyExchangeRate";

        /// <summary>"~/Api/Fiscal/{fiscalId}/Currency/{currencyAbbreviation}/ExchangeRate"</summary>
        public const string GetByCurrencyList = "~/Api/Fiscal/{fiscalId}/Currency/{currencyAbbreviation}/ExchangeRate";

        /// <summary>"CurrencyExchangeRateECB"</summary>
        public const string GetCurrencyExchangeRateECB = "CurrencyExchangeRateECB";

        /// <summary>"ExchangeRateByCurrency"</summary>
        public const string GetExchangeRateByCurrency = "ExchangeRateByCurrency";

        /// <summary>"ExactDate"</summary>
        public const string GetByExactDateAndCurrency = "ExactDate";
    }
}