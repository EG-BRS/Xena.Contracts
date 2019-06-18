namespace Xena.Contracts.ApiRoutes
{
    public class OrderTaskRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/OrderTask"</summary>
        public const string Base = "Fiscal/{fiscalId}/OrderTask";

        /// <summary>"~/Fiscal/{fiscalId}/Order/{id}/OrderTask"</summary>
        public const string GetByOrder = "~/Fiscal/{fiscalId}/Order/{id}/OrderTask";

        /// <summary>"~/Fiscal/{fiscalId}/Order/{id}/OrderTask"</summary>
        public const string GetByOrderNonInvoiced = "~/Fiscal/{fiscalId}/Order/{id}/OrderTask/NonInvoiced";

        /// <summary>"{id}/Journal"</summary>
        public const string GetJournal = "{id}/Journal";

        /// <summary>"{id}/Subscription"</summary>
        public const string PostSubscription = "{id}/Subscription";

        /// <summary>"{id}/Copy"</summary>
        public const string PostCopy = "{id}/Copy";

        /// <summary>"{id}/DeleteAllLines"</summary>
        public const string DeleteAllLines = "{id}/DeleteAllLines";

        /// <summary>"{id}/Confirmation"</summary>
        public const string DeleteConfirmation = "{id}/Confirmation";

        /// <summary>"GetOrderTaskForPartner/{id}"</summary>
        public const string GetOrderTaskForPartner = "GetOrderTaskForPartner/{id}";

        /// <summary>"GetListForFilteredOrderStatus"</summary>
        public const string GetListForFilteredOrderStatus = "GetListForFilteredOrderStatus";

        /// <summary>"GetComposite"</summary>
        public const string GetComposite = "Composite";
    }
}