using System.ComponentModel;
using Xena.Common.Constants;
using Xena.Contracts.Domain;
using Xena.Common.ExtensionMethods;

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

        private decimal? _disposableQuantity;
        [ReadOnly(true)]
        public decimal DisposableQuantity
        {
            get { return _disposableQuantity ?? AvailableQuantity - ReservedQuantity - ConfirmedSalesQuantity + ConfirmedPurchaseQuantity; }
            set { _disposableQuantity = value; }
        }

        private string _locationFriendlyText = null;
        [ReadOnly(true)]
        public string LocationFriendlyText
        {
            get
            {
                if (_locationFriendlyText != null)
                {
                    return _locationFriendlyText;
                }

                var disposableQuantity = ArticleHasInventoryManagement ? $" - {DisposableQuantity:N2}" : string.Empty;
                return $"{(string.IsNullOrEmpty(LocationAbbreviation) ? LocationStatus.None.GetLocalizedConstant() : LocationAbbreviation)}{disposableQuantity}";
            }
            set { _locationFriendlyText = value; }
        }

        private string _abbrevation;
        [ReadOnly(true)]
        public string Abbreviation
        {
            get { return _abbrevation ?? (string.IsNullOrEmpty(ArticleVariantAbbreviation)
                    ? ArticleNumber
                    : $"{ArticleNumber}-{ArticleVariantAbbreviation}");
            }
            set { _abbrevation = value; }
        }

        private string _description;
        [ReadOnly(true)]
        public string Description
        {
            get
            {
                var availableQuantity = ArticleHasInventoryManagement ? $" - {AvailableQuantity:N2}" : string.Empty;
                return _description ?? (string.IsNullOrEmpty(ArticleVariantAbbreviation)
                    ? $"{ArticleNumber} - {ArticleDescription}{availableQuantity}"
                    : $"{ArticleDescription} - {ArticleVariantAbbreviation}{availableQuantity}");
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
            if (obj.GetType() != GetType()) return false;
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