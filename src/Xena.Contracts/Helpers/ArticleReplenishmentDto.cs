using System;
using Xena.Contracts.Domain;

namespace Xena.Contracts.Helpers
{
    public class ArticleReplenishmentDto : IHasIdDto
    {
        private decimal? _orderLineAmount;
        public long? Id { get; set; }
        public long ArticleId { get; set; }
        public string ArticleDescription { get; set; }
        public string ArticleNumber { get; set; }
        public bool ArticleHasVariants { get; set; }
        public decimal AvailableQuantity { get; set; }
        public decimal DefaultPurchasingQuantity { get; set; }
        public decimal MinimumStock { get; set; }
        public decimal MaximumStock { get; set; }
        public decimal OpenPurchaseQuantity { get; set; }
        public decimal OpenSalesQuantity { get; set; }    
        public decimal AddedToPurchaseDraft { get; set; }
        public decimal ConfirmedPurchaseQuantity { get; set; }
        public decimal ConfirmedSalesQuantity { get; set; }
        public decimal PurchaseDraftQuantity { get; set; }
        public long FiscalSetupId { get; set; }
        public long? SupplierId { get; set; }
        public int? SupplierAccountNumber { get; set; }
        public decimal OrderLineAmount
        {
            get { return _orderLineAmount ?? Math.Max(Math.Ceiling((MaximumStock - AvailableQuantity - ConfirmedPurchaseQuantity + ConfirmedSalesQuantity - PurchaseDraftQuantity - AddedToPurchaseDraft) / DefaultPurchasingQuantity), 0) * DefaultPurchasingQuantity;}
            set { _orderLineAmount = value; }
        }
        public long? UnitId { get; set; }

        public string ArticleShortDescription { get; set; }
    }
}