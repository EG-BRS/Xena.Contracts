using Xena.Contracts.Domain;

namespace Xena.Contracts.Helpers
{
    public class CalculatedArticleAvailabilityTotalDto : IHasIdDto
    {
        public long? Id { get; set; }
        public long ArticleId { get; set; }
        public string ArticleNumber { get; set; }
        public string ArticleDescription { get; set; }
        public long? ArticleVariantId { get; set; }
        public string ArticleVariantAbbreviation { get; set; }
        public bool ArticleHasInventoryManagement { get; set; }
        public bool ArticleHasVariants { get; set; }
        public long FiscalSetupId { get; set; }
        public decimal AvailableQuantity { get; set; }
        public decimal? AverageCostPrice { get; set; }
        public decimal ReservedQuantity { get; set; }
        public decimal OpenSalesOrderQuantity { get; set; }
        public decimal OpenPurchaseOrderQuantity { get; set; }
        public decimal ConfirmedPurchaseQuantity { get; set; }
        public decimal ConfirmedSalesQuantity { get; set; }
        public string Abbreviation
        {
            get { return string.IsNullOrEmpty(ArticleVariantAbbreviation) ? ArticleNumber : string.Format("{0}-{1}", ArticleNumber, ArticleVariantAbbreviation); }
        }
        public decimal DisposableQuantity
        {
            get { return AvailableQuantity - ConfirmedSalesQuantity + ConfirmedPurchaseQuantity; }
        }

        public string Description
        {
            get
            {
                var disposableQuantity = ArticleHasInventoryManagement ? string.Format(" - {0}", DisposableQuantity.ToString("N2")) : string.Empty;
                return string.IsNullOrEmpty(ArticleVariantAbbreviation) 
                ? string.Format("{0} - {1}{2}", ArticleNumber, ArticleDescription, disposableQuantity)
                : string.Format("{0} - {1}{2}", ArticleDescription, ArticleVariantAbbreviation, disposableQuantity);
            }
        }
        protected bool Equals(CalculatedArticleAvailabilityTotalDto other)
        {
            return FiscalSetupId == other.FiscalSetupId && ArticleId == other.ArticleId && ArticleVariantId == other.ArticleVariantId;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((CalculatedArticleAvailabilityTotalDto)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = FiscalSetupId.GetHashCode();
                hashCode = (hashCode * 397) ^ ArticleId.GetHashCode();
                hashCode = (hashCode * 397) ^ ArticleVariantId.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator ==(CalculatedArticleAvailabilityTotalDto left, CalculatedArticleAvailabilityTotalDto right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CalculatedArticleAvailabilityTotalDto left, CalculatedArticleAvailabilityTotalDto right)
        {
            return !Equals(left, right);
        }
    }
}