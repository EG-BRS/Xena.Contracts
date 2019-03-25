namespace Xena.Contracts.ApiRoutes
{
    public class OrderInvoiceTransactionRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/OrderInvoiceTransaction"</summary>
        public const string Base = "Fiscal/{fiscalId}/OrderInvoiceTransaction";

        /// <summary>"{id}"</summary>
        public const string Get = "{id}";

        /// <summary>"{id}/RequestPayment/{subscriptionTicketId}"</summary>
        public const string PutRequestPayment = "{id}/RequestPayment/{subscriptionTicketId}";


    }
}