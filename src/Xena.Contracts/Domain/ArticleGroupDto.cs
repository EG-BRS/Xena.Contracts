using System.ComponentModel.DataAnnotations;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class ArticleGroupDto : EntityDto
    {
        [Required]
        [StringLength(255)]
        public string Description { get; set; }
        [Required]
        [StringLength(255)]
        public string EUType { get; set; }
        public int? NettTurnoverAccount { get; set; }
        public int? NettTurnoverVatFreeAccount { get; set; }
        public int? ProductPurchaseAccount { get; set; }
        public int? ProductPurchaseVatFreeAccount { get; set; }
        public string StatusMode { get; set; }     
        public int? StockAccount { get; set; }
        public int? StockReceptionAccount { get; set; }
        public int? UnpaidStockAccount { get; set; }
        public bool DefaultInventoryManagement { get; set; }

        //Convinience properties
        private string _euTypeTranslated = null;
        public string EUTypeTranslated
        {
            get
            {
                return _euTypeTranslated ?? (string.IsNullOrEmpty(EUType) ? string.Empty : EUType.GetLocalizedConstant());
            }
            set { _euTypeTranslated = value; }
        }

        private string _statusModeTranslated = null;
        public string StatusModeTranslated
        {
            get
            {
                return _statusModeTranslated ?? (string.IsNullOrEmpty(StatusMode) ? string.Empty : StatusMode.GetLocalizedConstant());
            }
            set { _statusModeTranslated = value; }
        }
    }
}