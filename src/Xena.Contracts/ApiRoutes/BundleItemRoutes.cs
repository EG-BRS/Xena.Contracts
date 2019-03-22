namespace Xena.Contracts.ApiRoutes
{
    public class BundleItemRoutes : BaseRoutes
    {
        /// <summary>"Api/Fiscal/{fiscalId}/BundleItem"</summary>
        public const string Base = "Api/Fiscal/{fiscalId}/BundleItem";

        /// <summary>"~/Api/Fiscal/{fiscalId}/Article/{id}/BundleItem"</summary>
        public const string GetByArticle = "~/Api/Fiscal/{fiscalId}/Article/{id}/BundleItem";
    }
}