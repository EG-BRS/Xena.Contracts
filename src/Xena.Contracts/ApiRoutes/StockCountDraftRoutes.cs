namespace Xena.Contracts.ApiRoutes
{
    public class StockCountDraftRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/StockCountDraft"</summary>
        public const string Base = "Fiscal/{fiscalId}/StockCountDraft";

        /// <summary>"~/Fiscal/{fiscalId}/StockCount/{id}/Draft"</summary>
        public const string GetByStockCount = "~/Fiscal/{fiscalId}/StockCount/{id}/Draft";

        /// <summary>"Multiple"</summary>
        public const string PutMultiple = "Multiple";

        /// <summary>"{id}/Reset"</summary>
        public const string PutReset = "{id}/Reset";
    }
}