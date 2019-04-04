namespace Xena.Contracts.ApiRoutes
{
    public class ExternalArticleProviderRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/ExternalArticleProvider"</summary>
        public const string Base = "Fiscal/{fiscalId}/ExternalArticleProvider";

        /// <summary>"PossibleSuppliers"</summary>
        public const string GetPossibleSuppliers = "PossibleSuppliers";

        /// <summary>"~/Fiscal/{fiscalId}/Partner/{id}/ExternalArticleProvider"</summary>
        public const string GetByPartner = "~/Fiscal/{fiscalId}/Partner/{id}/ExternalArticleProvider";

        /// <summary>"~/Fiscal/{fiscalId}/Supplier/{id}/ExternalArticleProviderr"</summary>
        public const string GetBySupplier = "~/Fiscal/{fiscalId}/Supplier/{id}/ExternalArticleProvider";
    }
}