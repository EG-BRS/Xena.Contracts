namespace Xena.Contracts.ApiRoutes
{
    public class OrderRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/Order"</summary>
        public const string Base = "Fiscal/{fiscalId}/Order";

        /// <summary>"OrderOffer"</summary>
        public const string GetOffer = "Offer";

        /// <summary>"~/Fiscal/{fiscalId}/Project/{id}/Order"</summary>
        public const string GetByProject = "~/Fiscal/{fiscalId}/Project/{id}/Order";

        /// <summary>"Statistics/Closed"</summary>
        public const string GetClosedOrderStatistics = "Statistics/Closed";

        /// <summary>"Pay"</summary>
        public const string PutPay = "Pay";

        /// <summary>"Process/Bulk"</summary>
        public const string PutProcessMass = "Process/Bulk";

        /// <summary>"Invoice/{id}/Cancel"</summary>
        public const string DeleteCancelOrderInvoice = "Invoice/{id}/Cancel";

        /// <summary>"Invoice/{id}/Cancel"</summary>
        public const string PutCancelOrderInvoice = "Invoice/{id}/Cancel";

        /// <summary>"Invoice/Cancel"</summary>
        public const string DeleteCancelMultipleOrderInvoice = "Invoice/Cancel";

        /// <summary>"Invoice/Cancel"</summary>
        public const string PutCancelMultipleOrderInvoice = "Invoice/Cancel";

        /// <summary>"FromArticleReplenishment"</summary>
        public const string PostFromArticleReplenishment = "FromArticleReplenishment";

        /// <summary>"OrderInvoice"</summary>
        public const string GetInvoice = "Invoice";

        /// <summary>"~/Fiscal/{fiscalId}/Partner/{id}/OrderInvoice"</summary>
        public const string GetInvoiceByPartner = "~/Fiscal/{fiscalId}/Partner/{id}/Invoice";

        /// <summary>"History"</summary>
        public const string GetHistory = "History";

        /// <summary>"OrdersForStatus"</summary>
        public const string GetOrdersForStatus = "OrdersForStatus/{id}";

        /// <summary>"~/Fiscal/{fiscalId}/Article/{id}/Order"</summary>
        public const string GetByArticle = "~/Fiscal/{fiscalId}/Article/{id}/Order";

        /// <summary>"~/Fiscal/{fiscalId}/Article/{id}/OpenOrder"</summary>
        public const string GetOpenByArticle = "~/Fiscal/{fiscalId}/Article/{id}/OpenOrder";

        /// <summary>"~/Fiscal/{fiscalId}/Article/{id}/ConfirmedOrder"</summary>
        public const string GetConfirmedByArticle = "~/Fiscal/{fiscalId}/Article/{id}/ConfirmedOrder";

        /// <summary>"~/Fiscal/{fiscalId}/Article/{id}/OrderArticleReservations"</summary>
        public const string GetOrderArticleReservationsByArticle = "~/Fiscal/{fiscalId}/Article/{id}/OrderArticleReservations";

        /// <summary>"~/Fiscal/{fiscalId}/Partner/{id}/Offer"</summary>
        public const string GetOfferByPartner = "~/Fiscal/{fiscalId}/Partner/{id}/Offer";

        /// <summary>"~/Fiscal/{fiscalId}/Partner/{id}/Order"</summary>
        public const string GetByPartner = "~/Fiscal/{fiscalId}/Partner/{id}/Order";

        /// <summary>"~/Fiscal/{fiscalId}/Subscription/{id}/Order"</summary>
        public const string GetBySubscription = "~/Fiscal/{fiscalId}/Subscription/{id}/Order";

        /// <summary>"~/Fiscal/{fiscalId}/Partner/{id}/OpenOrder"</summary>
        public const string GetOpenByPartner = "~/Fiscal/{fiscalId}/Partner/{id}/OpenOrder";

        /// <summary>"~/Fiscal/{fiscalId}/Partner/{id}/HasOpenOrder"</summary>
        public const string GetPartnerHasOpenOrders = "~/Fiscal/{fiscalId}/Partner/{id}/HasOpenOrder";

        /// <summary>"NotInvoiced"</summary>
        public const string GetNotInvoiced = "NotInvoiced";

        /// <summary>"Invoice/{id}/Copy"</summary>
        public const string PostInvoiceCopy = "Invoice/{id}/Copy";

        /// <summary>"{id}/Copy"</summary>
        public const string PostCopy = "{id}/Copy";

        /// <summary>"{id}/Deliver"</summary>
        public const string PutDeliver = "{id}/Deliver";

        /// <summary>"{id}/DeliveryData"</summary>
        public const string GetDeliveryData = "{id}/DeliveryData";

        /// <summary>"{id}/SupplierOrderDataByOrder"</summary>
        public const string GetSupplierOrderDataByOrder = "{id}/SupplierOrderDataByOrder";

        /// <summary>"{id}/PayOnAccountData"</summary>
        public const string GetPayOnAccountData = "{id}/PayOnAccountData";

        /// <summary>"{id}/GetOrderStatisticsData"</summary>
        public const string GetOrderStatisticsData = "{id}/GetOrderStatisticsData";

        /// <summary>"{id}/GetOrderTaskStatisticsData"</summary>
        public const string GetOrderTaskStatisticsData = "{id}/GetOrderTaskStatisticsData";

        /// <summary>"{id}/SplitLines"</summary>
        public const string PutSplitLines = "{id}/SplitLines";

        /// <summary>"FromLines"</summary>
        public const string PostFromOrderLines = "{partnerId}/FromLines";

        /// <summary>"{id}/Offer"</summary>
        public const string PutOffer = "{id}/Offer";

        /// <summary>"{id}/Confirmation"</summary>
        public const string PutConfirmation = "{id}/Confirmation";

        /// <summary>"{id}/Bookkeep"</summary>
        public const string PutBookkeep = "{id}/Bookkeep";

        /// <summary>"{id}/PayOnAccount"</summary>
        public const string PutPayOnAccount = "{id}/PayOnAccount";

        /// <summary>"{id}/Journal"</summary>
        public const string GetJournal = "{id}/Journal";

        /// <summary>"~/Fiscal/{fiscalId}/PartnerContext/{id}/UpdateOrder"</summary>
        public const string PutFromContext = "~/Fiscal/{fiscalId}/PartnerContext/{id}/UpdateOrder";

        /// <summary>"~/Fiscal/{fiscalId}/Partner/{id}/UpdateOrder"</summary>
        public const string PutFromPartner = "~/Fiscal/{fiscalId}/Partner/{id}/UpdateOrder";


        /// <summary>"ContextType"</summary>
        public const string GetContextType = "ContextType";

        /// <summary>"DueType"</summary>
        public const string GetDueType = "DueType";

        /// <summary>"{id}/PartnerPost"</summary>
        public const string GetPartnerPost = "{id}/PartnerPost";

        /// <summary>"{id}/Summary"</summary>
        public const string GetSummary = "{id}/Summary";

        /// <summary>"{id}/InvoiceSummary"</summary>
        public const string GetInvoiceSummary = "{id}/InvoiceSummary";

        /// <summary>"Invoice/SendElectronicInvoice"</summary>
        public const string PutSendElectronicInvoice = "Invoice/SendElectronicInvoice";

        /// <summary>"Invoice/SendMobilePayInvoice"</summary>
        public const string PutSendMobilePayInvoice = "Invoice/SendMobilePayInvoice";

        /// <summary>"RecipientAddressTypes"</summary>
        public const string GetRecipientAddressTypes = "RecipientAddressTypes";

        /// <summary>"GroupStatatistics"</summary>
        public const string GetGroupStatatistics = "GroupStatatistics";

        /// <summary>"DefaultElectronicInvoiceData"</summary>
        public const string GetDefaultElectronicInvoiceData = "DefaultElectronicInvoiceData";

        /// <summary>"DefaultMobilePayInvoiceData"</summary>
        public const string GetDefaultMobilePayInvoiceData = "DefaultMobilePayInvoiceData";

        /// <summary>"ElectronicInvoiceJournal/{id}/Events"</summary>
        public const string GetElectronicInvoiceJournalEvents = "ElectronicInvoiceJournal/{id}/Events";

        /// <summary>"{id}/CanBeSentElectronically"</summary>
        public const string ValidateOrderForElectronicInvoicing = "{id}/CanBeSentElectronically";

        /// <summary>"{id}/Barcodes"</summary>
        public const string PutUpdateWithBarcodes = "{id}/Barcodes";

        /// <summary>"Undelivered/Article/{id}"</summary>
        public const string GetUndeliveredOrdersByArticle = "Undelivered/Article/{id}";

        /// <summary>"Undelivered"</summary>
        public const string GetUndeliveredList = "Undelivered";

        /// <summary>"OrderJournalEntry/{id}/HasArticlesWithInventoryManagement"</summary>
        public const string GetHasOrderJournalArticlesWithInventoryManagement = "OrderJournalEntry/{id}/HasArticlesWithInventoryManagement";

        public const string PostCreatePurchaseOrderFromSalesOrder = "{id}/CreatePurchaseOrderFromSalesOrder";
    }
}