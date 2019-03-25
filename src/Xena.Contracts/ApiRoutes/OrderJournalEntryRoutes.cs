namespace Xena.Contracts.ApiRoutes
{
    public class OrderJournalEntryRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/OrderJournalEntry"</summary>
        public const string Base = "Fiscal/{fiscalId}/OrderJournalEntry";

        /// <summary>"{id}"</summary>
        public const string Get = "{id}";

        /// <summary>"{id}/Email"</summary>
        public const string PostEmail = "{id}/Email";
    }
}