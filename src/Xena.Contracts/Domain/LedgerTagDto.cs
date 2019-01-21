using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class LedgerTagDto : EntityDto
    {
        public string LedgerAccount { get; set; }
        public string LedgerTagType { get; set; }
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

        private string _ledgerTagTypeTranslated = null;
        [ReadOnly(true)]
        public string LedgerTagTypeTranslated
        {
            get
            {
                return _ledgerTagTypeTranslated ?? (string.IsNullOrEmpty(LedgerTagType)
                           ? string.Empty
                           : LedgerTagType.GetLocalizedConstant());
            }
            set { _ledgerTagTypeTranslated = value; }
        }
        public string Description { get; set; }
        public int? Number { get; set; }
        public long? DefaultVatId { get; set; }
        public long? LedgerTagGroupId { get; set; }
        public string LedgerTagGroupDescription { get; set; }
        public decimal? DefaultDeductionPercentage { get; set; }
        public string DefaultVatAbbreviation { get; set; }
        public string DefaultCurrencyAbbreviation { get; set; }
        private string _defaultCurrencyDescription = null;
        [ReadOnly(true)]
        public string DefaultCurrencyDescription
        {
            get { return _defaultCurrencyDescription ?? DefaultCurrencyAbbreviation.GetLocalizedCurrencyName(); }
            set { _defaultCurrencyDescription = value; }
        }
        private string _shortDescription = null;
        [ReadOnly(true)]
        public string ShortDescription
        {
            get { return _shortDescription ?? (Number?.ToString() ?? Description); }
            set { _shortDescription = value; }
        }
        private string _longDescription = null;
        [ReadOnly(true)]
        public string LongDescription
        {
            get { return _longDescription ?? (Number.HasValue ? $"{Number.Value} - {Description}" : Description); }
            set { _longDescription = value; }
        }

        public int? LedgerTagGroupIndex { get; set; }
    }
}