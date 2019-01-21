using System.ComponentModel;

namespace Xena.Contracts.Domain
{
    public class ImportedArticleDto : ImportedDto
    {
        public string OriginalId { get; set; }
        public string ArticleNumber { get; set; }
        public string Description { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public decimal UnitPrice { get; set; }
        public string SuppliersProductNo { get; set; }
        public long? ArticleGroupId { get; set; }
        public long? MappedArticleId { get; set; }

        //Convinience properties
        [ReadOnly(true)]
        public string ArticleGroupDescription { get; set; }
        [ReadOnly(true)]
        public string MappedArticleNumber { get; set; }
        [ReadOnly(true)]
        public string MappedArticleDescription { get; set; }
    }
}