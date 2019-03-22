namespace Xena.Contracts.ApiRoutes
{
    public class ExternalArticleProviderGroupSetupRoutes : BaseRoutes
    {
        /// <summary>"Api/Fiscal/{fiscalId}/ExternalArticleProvider"</summary>
        public const string Base = "Api/Fiscal/{fiscalId}/ExternalArticleProviderGroupSetup";

        /// <summary>"~/Api/Fiscal/{fiscalId}/ExternalArticleProvider/{id}/GroupSetup"</summary>
        public const string PostMultiple = "~/Api/Fiscal/{fiscalId}/ExternalArticleProvider/{id}/GroupSetup";

        /// <summary>"~/Api/Fiscal/{fiscalId}/ExternalArticleProvider/{id}/GroupSetup"</summary>
        public const string GetByExternalArticleProvider = "~/Api/Fiscal/{fiscalId}/ExternalArticleProvider/{id}/GroupSetup";

        /// <summary>"~/Api/Fiscal/{fiscalId}/ExternalArticleProvider/{id}/GroupSetup"</summary>
        public const string DeleteByExternalArticleProvider = "~/Api/Fiscal/{fiscalId}/ExternalArticleProvider/{id}/GroupSetup";
    }
}