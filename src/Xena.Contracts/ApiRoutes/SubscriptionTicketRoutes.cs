namespace Xena.Contracts.ApiRoutes
{
    public class SubscriptionTicketRoutes
    {
        /// <summary>"Route"</summary>
        public const string Base = "Fiscal/{fiscalId}/SubscriptionTicket";

        /// <summary>"{id}/HasWaitingPayments"</summary>
        public const string HasWaitingPayments = "{id}/HasWaitingPayments";

        /// <summary>"~/Fiscal/{fiscalId}/Subscription/{id}/Ticket"</summary>
        public const string Post = "~/Fiscal/{fiscalId}/Subscription/{subscriptionId}/Ticket";
    }
}