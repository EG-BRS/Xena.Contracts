namespace Xena.Contracts.ApiRoutes
{
    public class StockCountRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/StockCount"</summary>
        public const string Base = "Fiscal/{fiscalId}/StockCount";

        /// <summary>"{id}/CanBookkeep"</summary>
        public const string GetCanBookkeep = "{id}/CanBookkeep";


        /// <summary>"{id}/Bookkeep"</summary>
        public const string PutBookkeep = "{id}/Bookkeep";

        /// <summary>"{id}/Reset"</summary>
        public const string PutReset = "{id}/Reset";
    }
}