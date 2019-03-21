namespace Xena.Contracts.ApiRoutes
{
    public class ArticleGroupRoutes : BaseRoutes
    {
            /// <summary>"Api/Fiscal/{fiscalId}/ArticleGroup"</summary>
            public const string Base = "Api/Fiscal/{fiscalId}/ArticleGroup";

            /// <summary>"History"</summary>
            public const string GetHistoryList = "History";

            /// <summary>"{id}/DuplicateAccountNumbers"</summary>
            public const string GetDuplicateAccountNumbers = "{id}/DuplicateAccountNumbers";

            /// <summary>"{articleGroupToDeactivateId}/MergeInto/{articleGroupToKeepId}"</summary>
            public const string DeleteMerge = "{articleGroupToDeactivateId}/MergeInto/{articleGroupToKeepId}";

            /// <summary>"{id}/DeleteArticles"</summary>
            public const string DeleteArticles = "{id}/DeleteArticles";

            /// <summary>"EUType"</summary>
            public const string GetEUTypeList = "EUType";
    }
}