namespace Xena.Contracts.Search
{
    public class ArticleVariantSearchIndex
    {
        public long Id { get; set; }
        public string ArticleNumber { get; set; }
        public string ArticleDescription { get; set; }
        public string Description { get; set; }
        public string Abbreviation { get; set; }
        public string AbbreviationRaw { get; set; }
        public string GroupDescription { get; set; }
        public long FiscalSetupId { get; set; }
        public string ArticleNumberRaw { get; set; }
        
    }
}