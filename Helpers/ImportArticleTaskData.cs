namespace Xena.Contracts.Helpers
{
    public class ImportArticleTaskData : BaseImportTaskData
    {
        public ArticleManualImportData[] Articles { get; set; }
    }
}