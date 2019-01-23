using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Xena.Contracts.Domain
{
    public class ArticleDto : EntityDto
    {
        public ArticleDto()
        {
            PurchasingSetup = new OrderSetupDto();
            SalesSetup = new OrderSetupDto();
        }

        public ArticleDto(string articleGroupDescription, decimal? salesPrice = null)
            :this()
        {
            ArticleGroupDescription = articleGroupDescription;
            SalesPrice = salesPrice;
        }
        [Required]
        [StringLength(255,MinimumLength = 1)]
        public string ArticleNumber { get; set; }
        public string InternalNote { get; set; }
        public OrderSetupDto PurchasingSetup { get; set; }
        [Required]
        public string Description { get; set; }
        public OrderSetupDto SalesSetup { get; set; }
        [Required]
        public long? GroupId { get; set; }
        public long? PartnerSupplierContextId { get; set; }
        public long? SupplierId { get; set; }
        public decimal? MinimumStock { get; set; }
        public decimal? MaximumStock { get; set; }
        public bool? HasSerialNumber { get; set; }
        public bool? HasBatchNumber { get; set; }
        public long? DefaultLocationId { get; set; }
        public decimal? Weight { get; set; }
        public bool HasInventoryManagement { get; set; }

        //Convinience properties
        [ReadOnly(true)]
        public decimal? AverageCostPrice { get; set; }
        [ReadOnly(true)]
        public bool HasVariants { get; set; }
        [ReadOnly(true)]
        public string ArticleGroupDescription { get; set; }
        [ReadOnly(true)]
        public string SalesUnitAbbreviation { get; set; }
        [ReadOnly(true)]
        public string PurchasingUnitAbbreviation { get; set; }
        [ReadOnly(true)]
        public string DefaultLocationAbbreviation { get; set; }
        [ReadOnly(true)]
        public decimal? PurchasePrice { get; set; }
        [ReadOnly(true)]
        public string PurchaseCurrencyAbbreviation { get;set; }
        [ReadOnly(true)]
        public decimal? SalesPrice { get; set; }
        [ReadOnly(true)]
        public string SalesCurrencyAbbreviation { get; set; }
        [ReadOnly(true)]
        public bool AdvancedSalesPrices { get; set; }
        [ReadOnly(true)]
        public bool AdvancedPurchasePrices { get; set; }
        [ReadOnly(true)]
        public bool IsBundle { get; set; }
        [ReadOnly(true)]
        public int? SupplierAccountNumber { get; set; }
        [ReadOnly(true)]
        public string SupplierName { get; set; }

        private string _descriptionFriendly;
        [ReadOnly(true)]
        public string DescriptionFriendly
        {
            get { return _descriptionFriendly ?? (string.IsNullOrEmpty(ArticleNumber) ? Description : $"{ArticleNumber} - {Description}"); }
            set { _descriptionFriendly = value; }
        }
    }
}