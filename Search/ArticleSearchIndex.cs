namespace Xena.Contracts.Search
{
    public class ArticleSearchIndex
    {
        public long Id { get; set; }
        public string ArticleNumber { get; set; }
        public string Description { get; set; }
        public string GroupDescription { get; set; }
        public long FiscalSetupId { get; set; }
        public string ArticleNumberRaw { get; set; }
    }
}