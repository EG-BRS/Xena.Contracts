using System.ComponentModel;

namespace Xena.Contracts.Helpers
{
    public class OrderDeliveryLineData
    {
        public long OrderLineId { get; set; }
        public string Description { get; set; }
        public long? ArticleId { get; set; }
        public string ArticleNumber { get; set; }
        private string _articleAbbreviation = null;
        [ReadOnly(true)]
        public string ArticleAbbreviation
        {
            get
            {
                return _articleAbbreviation ?? (string.IsNullOrEmpty(ArticleVariantAbbreviation)
                           ? ArticleNumber
                           : string.Format("{0}-{1}", ArticleNumber, ArticleVariantAbbreviation));
            }
            set { _articleAbbreviation = value; }
        }
        public long? ArticleVariantId { get; set; }
        public string ArticleVariantAbbreviation { get; set; }
        public long? UnitId { get; set; }
        public string UnitAbbreviation { get; set; }
        public decimal Quantity { get; set; }
        public decimal? AvailableQuantity { get; set; }
        public string MappedArticleNumber { get; set; }
    }
}