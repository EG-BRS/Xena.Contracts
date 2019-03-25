namespace Xena.Contracts.ApiRoutes
{
    public class LedgerPostRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/BankPosting"</summary>
        public const string Base = "Fiscal/{fiscalId}/LedgerPost";

        /// <summary>"LedgerTag/{id}/LedgerPosts"</summary>
        public const string GetByLedgerTag = BaseFiscalUri + "LedgerTag/{id}/LedgerPost";

        /// <summary>"ArticleGroup/{id}/LedgerPost"</summary>
        public const string GetByArticleGroup = BaseFiscalUri + "ArticleGroup/{id}/LedgerPost";
    }
}