using System.Collections.Generic;
using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class ArticleDto : EntityDto
    {
        public ArticleDto()
        {
            PurchasingSetup = new OrderSetupDto();
            SalesSetup = new OrderSetupDto();
        }
        public string ArticleNumber { get; set; }
        public bool HasVariants { get; set; }
        public OrderSetupDto PurchasingSetup { get; set; }
        public string Description { get; set; }
        public OrderSetupDto SalesSetup { get; set; }
        public long GroupId { get; set; }
        public long? PartnerSupplierContextId { get; set; }
        public int? SupplierAccountNumber { get; set; }
        public string SupplierName { get; set; }
        public long? SupplierId { get; set; }
        public decimal? AverageCostPrice { get; set; }
        public decimal? MinimumStock { get; set; }
        public decimal? MaximumStock { get; set; }
        public bool HasInventoryManagement { get; set; }
        public bool? HasSerialNumber { get; set; }
        public bool? HasBatchNumber { get; set; }
        public string ArticleGroupDescription { get; set; }
        public string SalesUnitAbbreviation { get; set; }
        public string PurchasingUnitAbbreviation { get; set; }
        public long? DefaultLocationId { get; set; }
        public string DefaultLocationAbbreviation { get; set; }
        
        public decimal? PurchasePrice { get; set; }
        public string PurchaseCurrencyAbbreviation { get; set; }
        public decimal? SalesPrice { get; set; }
        public string SalesCurrencyAbbreviation { get; set; }
        public bool AdvancedSalesPrices { get; set; }
        public bool AdvancedPurchasePrices { get; set; }

        public decimal? Weight { get; set; }

        public string DescriptionFriendly => string.IsNullOrEmpty(ArticleNumber) ? Description : $"{ArticleNumber} - {Description}";

        public bool IsBundle { get; set; }
    }
}