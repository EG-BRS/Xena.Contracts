using Xena.Resources;

namespace Xena.Contracts.Helpers
{
    public class VatReconciliationData
    {
        public long? LedgerTagId { get; set; }
        public int? LedgerTagNumber { get; set; }
        public string LedgerTagDescription { get; set; }
        public long? ArticleGroupId { get; set; }
        public string ArticleGroupDescription { get; set; }
        public string LedgerAccount { get; set; }

        public string LedgerAccountTranslated
        {
            get { return string.IsNullOrEmpty(LedgerAccount) ? string.Empty : LedgerAccount.GetLocalizedConstant(); }
        }
        public decimal Basis { get; set; }
        public decimal VatAmount { get; set; }
        public decimal ExpectedVatAmount { get; set; }
        public decimal DeductableAmount { get; set; }
        public decimal DeductablePercentage { get; set; }
    }
}