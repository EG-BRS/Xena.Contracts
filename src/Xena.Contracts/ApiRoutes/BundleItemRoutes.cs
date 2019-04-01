namespace Xena.Contracts.ApiRoutes
{
    public class BundleItemRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/BundleItem"</summary>
        public const string Base = "Fiscal/{fiscalId}/BundleItem";

        /// <summary>"~/Fiscal/{fiscalId}/Article/{id}/BundleItem"</summary>
        public const string GetByArticle = "~/Fiscal/{fiscalId}/Article/{id}/BundleItem";
    }
}