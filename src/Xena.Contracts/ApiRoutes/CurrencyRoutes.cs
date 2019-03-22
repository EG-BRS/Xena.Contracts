namespace Xena.Contracts.ApiRoutes
{
    public class CurrencyRoutes
    {
        /// <summary>"Api/Fiscal/{fiscalId}/Currency"</summary>
        public const string Base = "Api/Fiscal/{fiscalId}/Currency";

        /// <summary>""</summary>
        public const string GetList = "";

        /// <summary>"{currencyAbbreviation}/ExchangeRateByDate"</summary>
        public const string GetExchangeRate = "{currencyAbbreviation}/ExchangeRateByDate";

        /// <summary>"{currencyAbbreviation}/CurrencyAmountToPay"</summary>
        public const string GetCurrencyAmountToPay = "{currencyAbbreviation}/CurrencyAmountToPay";
    }
}