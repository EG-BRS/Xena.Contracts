namespace Xena.Contracts.ApiRoutes
{
    public class BarCodeRoutes : BaseRoutes
    {
        /// <summary>"Api/Fiscal/{fiscalId}/BarCode"</summary>
        public const string Base = "Api/Fiscal/{fiscalId}/BarCode";

        /// <summary>"~/Api/Fiscal/{fiscalId}/Article/{id}/BarCode"</summary>
        public const string GetByArticleList = "~/Api/Fiscal/{fiscalId}/Article/{id}/BarCode";

        /// <summary>"Multiple"</summary>
        public const string PostMultiple = "Multiple";

        /// <summary>"ByEANNumber/{eanNumber}"</summary>
        public const string ByEANNumber = "ByEANNumber/{eanNumber}";
    }
}