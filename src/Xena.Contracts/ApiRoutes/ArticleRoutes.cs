namespace Xena.Contracts.ApiRoutes
{
    public class ArticleRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/Article"</summary>
        public const string Base = "Fiscal/{fiscalId}/Article";

        /// <summary>"Multiple"</summary>
        public const string PostMultiple = "Multiple/{currency}";

        /// <summary>"Inventory/Multiple"</summary>
        public const string PutInventoryMultiple = "Inventory/Multiple";

        /// <summary>"{id}/Copy"</summary>
        public const string PostCopy = "{id}/Copy";

        /// <summary>"Search"</summary>
        public const string GetSearch = "Search";

        /// <summary>"PostMultipleForImportTask"</summary>
        public const string PostMultipleForImportTask = "MultipleForImportTask";

        /// <summary>"/Availability"</summary>
        public const string BaseAvailability = Base + "/Availability";

        // <summary>"{id}/IsArticleGroupReadonly"</summary>
        public const string GetIsArticleGroupReadOnly = "{id}/IsArticleGroupReadonly";

        /// <summary>"Exists"</summary>
        public const string GetExists = "Exists";

        /// <summary>"ByNumber"</summary>
        public const string GetByNumber = "ByNumber";

        /// <summary>"AdditionalArticle/{id}"</summary>
        public const string DeleteAdditionalArticle = "AdditionalArticle/{id}";

        /// <summary>"{id}/EnableInventory"</summary>
        public const string PutEnableInventory = "{id}/EnableInventory";

        /// <summary>"{id}/EnableBundle"</summary>
        public const string PutEnableBundle = "{id}/EnableBundle";

        /// <summary>"{id}/AdjustAveragePrice"</summary>
        public const string PutAdjustAveragePrice = "{id}/AdjustAveragePrice";

        /// <summary>"{id}/DisableInventory"</summary>
        public const string PutDisableInventory = "{id}/DisableInventory";

        /// <summary>"{id}/DisableBundle"</summary>
        public const string PutDisableBundle = "{id}/DisableBundle";

        /// <summary>"{id}/EnableArticleVariants"</summary>
        public const string PutEnableArticleVariants = "{id}/EnableArticleVariants";

        /// <summary>"{id}/AveragePriceChange"</summary>
        public const string GetAveragePriceChangeList = "{id}/AveragePriceChange";

        /// <summary>"{id}/UpdateSupplier"</summary>
        public const string PutUpdateSupplier = "{id}/UpdateSupplier";

        /// <summary>"{id}/DisableArticleVariants"</summary>
        public const string PutDisableArticleVariants = "{id}/DisableArticleVariants";

        /// <summary>"Availability"</summary>
        public const string GetAvailabilityList = "Availability";

        /// <summary>"AvailabilityByLocation"</summary>
        public const string GetArticleAvailabilityListByLocationList = "AvailabilityByLocation";

        /// <summary>"{id}/Variant"</summary>
        public const string GetVariantList = "{id}/Variant";

        /// <summary>"~/Fiscal/{fiscalId}/ArticleGroup/{id}/Article"</summary>
        public const string GetByGroupList = "~/Fiscal/{fiscalId}/ArticleGroup/{id}/Article";

        /// <summary>"{id}/Availablity"</summary>
        public const string GetAvailabilityListByArticle = "{id}/Availablity";

        /// <summary>"SpecifyVariants"</summary>
        public const string PostSpecifyVariants = "SpecifyVariants";

        /// <summary>"ArticleVariant"</summary>
        public const string GetArticleVariantList = "ArticleVariant";

        /// <summary>"{id}/AvailabilityByLocation"</summary>
        public const string GetAvailabilityByLocationList = "{id}/AvailabilityByLocation";

        /// <summary>"ArticleInventoryLow"</summary>
        public const string GetArticleInventoryLowList = "ArticleInventoryLow";

        /// <summary>"LocationInventoryLow"</summary>
        public const string GetLocationInventoryLowList = "LocationInventoryLow";

        /// <summary>"History"</summary>
        public const string GetHistoryList = "History";

        /// <summary>"Partner/{partnerId}"</summary>
        public const string PostMultiplePartnerArticles = "Partner/{partnerId}";

        /// <summary>"~/Fiscal/{fiscalId}/ArticleGroup/{id}/Article/EnableInventory"</summary>
        public const string PutEnableInventoryByGroup = "~/Fiscal/{fiscalId}/ArticleGroup/{id}/Article/EnableInventory";

        /// <summary>"~/Fiscal/{fiscalId}/ArticleGroup/{id}/Article/DisableInventory"</summary>
        public const string PutDisableInventoryByGroup = "~/Fiscal/{fiscalId}/ArticleGroup/{id}/Article/DisableInventory";

    }
}