namespace Xena.Contracts.Helpers
{
    public class XenaSubscriptionPriceData
    {
        public decimal MonthlyPrice { get; set; }
        public decimal MonthlyPriceNet { get; set; }
        public string CurrencyAbbrevation { get; set; }
        public decimal PriceForRestOfMonth { get; set; }
        public decimal PriceForRestOfMonthNet { get; set; }
        public decimal TotalSubscriptionPrice { get; set; }
        public decimal TotalSubscriptionPriceNet { get; set; }
        public bool RequirePaymentForNewRoles { get; set; }
        public long? XenaSubscriptionId { get; set; }
    }
}