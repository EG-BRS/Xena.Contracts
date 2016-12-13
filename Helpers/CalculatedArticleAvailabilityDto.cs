using Xena.Contracts.Domain;
using Xena.Resources;

namespace Xena.Contracts.Helpers
{
    public class CalculatedArticleAvailabilityDto : IHasIdDto
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
        public long? LocationId { get; set; }
        public long? WarehouseId { get; set; }
        public string WarehouseDescription { get; set; }
        public string LocationAbbreviation { get; set; }

        public decimal DisposableQuantity
        {
            get { return AvailableQuantity - ReservedQuantity - ConfirmedSalesQuantity + ConfirmedPurchaseQuantity; }
        }

        public string LocationFriendlyText
        {
            get
            {
                var disposableQuantity = ArticleHasInventoryManagement ? string.Format(" - {0}", DisposableQuantity.ToString("N2")) : string.Empty;
                return string.Format("{0}{1}", string.IsNullOrEmpty(LocationAbbreviation) ? UI.Location_None : LocationAbbreviation, disposableQuantity);
            }
        }
        public string Abbreviation
        {
            get { return string.IsNullOrEmpty(ArticleVariantAbbreviation) ? ArticleNumber : string.Format("{0}-{1}", ArticleNumber, ArticleVariantAbbreviation); }
        }
        public string Description
        {
            get
            {
                var availableQuantity = ArticleHasInventoryManagement ? string.Format(" - {0}", AvailableQuantity.ToString("N2")):string.Empty;
                return string.IsNullOrEmpty(ArticleVariantAbbreviation) 
                    ? string.Format("{0} - {1}{2}", ArticleNumber, ArticleDescription, availableQuantity)
                    : string.Format("{0} - {1}{2}", ArticleDescription, ArticleVariantAbbreviation, availableQuantity);
            }
        }
        protected bool Equals(CalculatedArticleAvailabilityDto other)
        {
            return FiscalSetupId == other.FiscalSetupId && ArticleId == other.ArticleId && ArticleVariantId == other.ArticleVariantId && LocationId == other.LocationId;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((CalculatedArticleAvailabilityDto)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = FiscalSetupId.GetHashCode();
                hashCode = (hashCode * 397) ^ ArticleId.GetHashCode();
                hashCode = (hashCode * 397) ^ ArticleVariantId.GetHashCode();
                hashCode = (hashCode * 397) ^ LocationId.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator ==(CalculatedArticleAvailabilityDto left, CalculatedArticleAvailabilityDto right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CalculatedArticleAvailabilityDto left, CalculatedArticleAvailabilityDto right)
        {
            return !Equals(left, right);
        }
    }
}