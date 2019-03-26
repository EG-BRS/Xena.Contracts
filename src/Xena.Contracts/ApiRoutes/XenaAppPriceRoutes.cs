namespace Xena.Contracts.ApiRoutes
{
    public class XenaAppPriceRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/XenaAppPrice"</summary>
        public const string Base = "Fiscal/{fiscalId}/XenaAppPrice";

        /// <summary>"~/Fiscal/{fiscalId}/XenaApp/{id}/Price"</summary>
        public const string GetByXenaApp = "~/Fiscal/{fiscalId}/XenaApp/{id}/Price";
    }
}