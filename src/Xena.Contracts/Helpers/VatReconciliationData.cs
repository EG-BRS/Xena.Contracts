using System.ComponentModel;
using Xena.Common.ExtensionMethods;

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

        private string _ledgerAccountTranslated = null;
        [ReadOnly(true)]
        public string LedgerAccountTranslated
        {
            get
            {
                return _ledgerAccountTranslated ?? (string.IsNullOrEmpty(LedgerAccount)
                           ? string.Empty
                           : LedgerAccount.GetLocalizedConstant());
            }
            set { _ledgerAccountTranslated = value; }
        }
        public decimal Basis { get; set; }
        public decimal VatAmount { get; set; }
        public decimal ExpectedVatAmount { get; set; }
        public decimal DeductableAmount { get; set; }
        public decimal DeductablePercentage { get; set; }

        private decimal? _differenceAmount;
        public decimal DifferenceAmount
        {
            get => _differenceAmount ?? VatAmount - ExpectedVatAmount;
            set => _differenceAmount = value;
        }
    }
}