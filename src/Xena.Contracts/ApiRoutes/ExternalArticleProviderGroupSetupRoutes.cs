namespace Xena.Contracts.ApiRoutes
{
    public class ExternalArticleProviderGroupSetupRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/ExternalArticleProvider"</summary>
        public const string Base = "Fiscal/{fiscalId}/ExternalArticleProviderGroupSetup";

        /// <summary>"~/Fiscal/{fiscalId}/ExternalArticleProvider/{id}/GroupSetup"</summary>
        public const string PostMultiple = "~/Fiscal/{fiscalId}/ExternalArticleProvider/{id}/GroupSetup";

        /// <summary>"~/Fiscal/{fiscalId}/ExternalArticleProvider/{id}/GroupSetup"</summary>
        public const string GetByExternalArticleProvider = "~/Fiscal/{fiscalId}/ExternalArticleProvider/{id}/GroupSetup";

        /// <summary>"~/Fiscal/{fiscalId}/ExternalArticleProvider/{id}/GroupSetup"</summary>
        public const string DeleteByExternalArticleProvider = "~/Fiscal/{fiscalId}/ExternalArticleProvider/{id}/GroupSetup";
    }
}