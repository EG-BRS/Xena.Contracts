namespace Xena.Contracts.ApiRoutes
{
    public class LedgerRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/Ledger"</summary>
        public const string Base = "Fiscal/{fiscalId}/Ledger";

        /// <summary>"{id}/Bookkeep"</summary>
        public const string PutBookkeep = "{id}/Bookkeep";

        /// <summary>"{id}/NextVoucherNumbers"</summary>
        public const string GetNextVoucherNumbers = "{id}/NextVoucherNumbers";

        /// <summary>"{id}/Lines"</summary>
        public const string DeleteLines = "{id}/Lines";

        /// <summary>"{id}/Summary"</summary>
        public const string GetSummary = "{id}/Summary";

        /// <summary>"Default"</summary>
        public const string PostDefault = "Default";
    }
}