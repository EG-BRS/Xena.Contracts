namespace Xena.Contracts.ApiRoutes
{
    public class ExternalArticleProviderRoutes : BaseRoutes
    {
        /// <summary>"Api/Fiscal/{fiscalId}/ExternalArticleProvider"</summary>
        public const string Base = "Api/Fiscal/{fiscalId}/ExternalArticleProvider";

        /// <summary>"PossibleSuppliers"</summary>
        public const string GetPossibleSuppliers = "PossibleSuppliers";

        /// <summary>"~/Api/Fiscal/{fiscalId}/Partner/{id}/ExternalArticleProvider"</summary>
        public const string GetByPartner = "~/Api/Fiscal/{fiscalId}/Partner/{id}/ExternalArticleProvider";

        /// <summary>"~/Api/Fiscal/{fiscalId}/Supplier/{id}/ExternalArticleProviderr"</summary>
        public const string GetBySupplier = "~/Api/Fiscal/{fiscalId}/Supplier/{id}/ExternalArticleProvider";
    }
}