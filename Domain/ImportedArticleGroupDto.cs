namespace Xena.Contracts.Domain
{
    public class ImportedArticleGroupDto : ImportedDto
    {
        public string OriginalId { get; set; }
        public string Description { get; set; }
        public long? MappedArticleGroupId { get; set; }
        public string MappedArticleGroupDescription { get; set; }
        public int ArticleCount { get; set; }
        public int LinkedArticleCount { get; set; }
    }
}