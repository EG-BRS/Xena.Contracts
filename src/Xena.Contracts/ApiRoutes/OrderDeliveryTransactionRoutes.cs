namespace Xena.Contracts.ApiRoutes
{
    public static class OrderDeliveryTransactionRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/OrderDeliveryTransaction"</summary>
        public const string Base = "Fiscal/{fiscalId}/OrderDeliveryTransaction";

        /// <summary>"~/Fiscal/{fiscalId}/Order/{id}/DeliveryTransaction"</summary>
        public const string GetByOrder = "~/Fiscal/{fiscalId}/Order/{id}/DeliveryTransaction";

        /// <summary>"{id}/Delivery"</summary>
        public const string DeleteDelivery = "{id}/Delivery";

        /// <summary>"DeleteMultipleDeliveries"</summary>
        public const string DeleteMultipleDeliveries = "DeleteMultipleDeliveries";

    }
}