namespace Xena.Contracts.ApiRoutes
{
    public class BarCodeRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/BarCode"</summary>
        public const string Base = "Fiscal/{fiscalId}/BarCode";

        /// <summary>"~/Fiscal/{fiscalId}/Article/{id}/BarCode"</summary>
        public const string GetByArticleList = "~/Fiscal/{fiscalId}/Article/{id}/BarCode";

        /// <summary>"Multiple"</summary>
        public const string PostMultiple = "Multiple";

        /// <summary>"ByEANNumber/{eanNumber}"</summary>
        public const string ByEANNumber = "ByEANNumber/{eanNumber}";
    }
}