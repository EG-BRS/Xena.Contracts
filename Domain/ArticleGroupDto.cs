using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class ArticleGroupDto : EntityDto
    {
        public string Description { get; set; }
        public string EUType { get; set; }
        public string EUTypeTranslated => string.IsNullOrEmpty(EUType) ? string.Empty: EUType.GetLocalizedConstant();
        public int? NettTurnoverAccount { get; set; }
        public int? NettTurnoverVatFreeAccount { get; set; }
        public int? ProductPurchaseAccount { get; set; }
        public int? ProductPurchaseVatFreeAccount { get; set; }
        public int? StockAccount { get; set; }
        public int? StockReceptionAccount { get; set; }
        public int? UnpaidStockAccount { get; set; }
        public bool DefaultInventoryManagement { get; set; }
    }
}