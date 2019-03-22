namespace Xena.Contracts.ApiRoutes
{
    public class AdditionalArticleRoutes : BaseRoutes
    {
        /// <summary>"Api/Fiscal/{fiscalId}/AdditionalArticle"</summary>
        public const string Base = "Api/Fiscal/{fiscalId}/AdditionalArticle";

        /// <summary>"~/Api/Fiscal/{fiscalId}/Article/{id}/AdditionalArticle"</summary>
        public const string GetByArticle = "~/Api/Fiscal/{fiscalId}/Article/{id}/AdditionalArticle";
    }
}