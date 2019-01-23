using System.ComponentModel;

namespace Xena.Contracts.Domain
{
    public class ImportedArticleGroupDto : ImportedDto
    {
        public string OriginalId { get; set; }
        public string Description { get; set; }
        public long? MappedArticleGroupId { get; set; }
        public int ArticleCount { get; set; }

        //Convinience properties
        [ReadOnly(true)]
        public int LinkedArticleCount { get; set; }
        [ReadOnly(true)]
        public string MappedArticleGroupDescription { get; set; }
    }
}