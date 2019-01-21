using System.ComponentModel;
using Xena.Contracts.Domain;

namespace Xena.Contracts.Helpers
{
    public class SupplierOrderLineData : IHasIdDto
    {
        public long? Id { get; set; }
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
                           : $"{ArticleNumber}-{ArticleVariantAbbreviation}");
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
        public string StatusMode { get; set; }
        public long? SupplierId { get; set; }
        public string SupplierName { get; set; }
        public int? SupplierAccountNumber { get; set; }
        public bool HasVariants { get; set; }
        public string ArticleVariantDescription { get; set; }
        public string ArticleDescription { get; set; }
        public long? OrderTaskId { get; set; }
        public string OrderTaskDescription { get; set; }
        public string OrderTaskAbbreviation { get; set; }
        public bool HasInventoryManagement { get; set; }
    }
}
