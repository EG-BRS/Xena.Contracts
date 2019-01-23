using System.ComponentModel;

namespace Xena.Contracts.Domain
{
    public class PrimoArticlePostDto : EntityDto
    {
        public long FiscalPeriodId { get; set; }
        public decimal AveragePrice { get; set; }
        public decimal Quantity { get; set; }
        public long? ArticleId { get; set; }
        public long? ArticleVariantId { get; set; }
        public long? LocationId { get; set; }
        public string LocationAbbreviation { get; set; }
        public string ArticleDescription { get; set; }
        public string ArticleVariantAbbreviation { get; set; }
        public string ArticleVariantDescription { get; set; }
        public string ArticleNumber { get; set; }

        private string _articleAbbreviation = null;
        [ReadOnly(true)]
        public string ArticleAbbreviation
        {
            get { return _articleAbbreviation ?? (string.IsNullOrEmpty(ArticleVariantAbbreviation) ? ArticleNumber : string.Format("{0}-{1}", ArticleNumber, ArticleVariantAbbreviation)); }
            set { _articleAbbreviation = value; }
        }

        private string _description = null;
        [ReadOnly(true)]
        public string Description
        {
            get { return _description ?? (string.IsNullOrEmpty(ArticleVariantDescription) ? ArticleDescription : string.Format("{0} - {1}", ArticleDescription, ArticleVariantDescription)); }
            set { _description = value; }
        }
    }
}