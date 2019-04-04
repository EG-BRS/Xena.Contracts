namespace Xena.Contracts.ApiRoutes
{
    public class OrderStatusRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/OrderStatus"</summary>
        public const string Base = "Fiscal/{fiscalId}/OrderStatus";

        /// <summary>"StandardSales"</summary>
        public const string PostCreateStandardSales = "StandardSales";
        /// <summary>"StandardPurchasing"</summary>
        public const string PostCreateStandardPurchasing = "StandardPurchasing";
    }
}