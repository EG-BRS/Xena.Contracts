namespace Xena.Contracts.ApiRoutes
{
    public class AdditionalArticleRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/AdditionalArticle"</summary>
        public const string Base = "Fiscal/{fiscalId}/AdditionalArticle";

        /// <summary>"~/Fiscal/{fiscalId}/Article/{id}/AdditionalArticle"</summary>
        public const string GetByArticle = "~/Fiscal/{fiscalId}/Article/{id}/AdditionalArticle";
    }
}