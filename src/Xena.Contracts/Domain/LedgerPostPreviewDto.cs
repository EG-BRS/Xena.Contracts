using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class LedgerPostPreviewDto : EntityDto
    {
        public int Index { get; set; }
        public long VoucherPreviewId { get; set; }
        public decimal? Amount { get; set; }
        public long? LedgerTagId { get; set; }
        public long? VatId { get; set; }
        public long? ArticleGroupId { get; set; }
        public string Description { get; set; }
        public long? DepartmentId { get; set; }
        public long? PurposeId { get; set; }
        public long? BearerId { get; set; }
        public decimal? VatDeductionPercentage { get; set; }
        public string LedgerPostPreviewType { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public string LedgerAccount { get; set; }

        //Convinience properties
        [ReadOnly(true)]
        public int? LedgerTagNumber { get; set; }
        [ReadOnly(true)]
        public string LedgerTagDescription { get; set; }
        [ReadOnly(true)]
        public string VatAbbreviation { get; set; }
        [ReadOnly(true)]
        public string VatDescription { get; set; }
        [ReadOnly(true)]
        public string ArticleGroupDescription { get; set; }
        [ReadOnly(true)]
        public string PurposeDescription { get; set; }
        [ReadOnly(true)]
        public string DepartmentDescription { get; set; }
        [ReadOnly(true)]
        public string BearerDescription { get; set; }
        [ReadOnly(true)]
        public int? AccountNumber { get; set; }
        private string _lineDescription = null;
        [ReadOnly(true)]
        public string LineDescription
        {
            get
            {
                if (_lineDescription != null)
                {
                    return _lineDescription;
                }
                var description = LedgerTagId.HasValue ? LedgerTagDescription : ArticleGroupId.HasValue ? ArticleGroupDescription : string.Empty;
                return AccountNumber.HasValue ? $"{AccountNumber} {description}" : description;
            }
            set { _lineDescription = value; }
        }

        private string _shortDescription = null;
        [ReadOnly(true)]
        public string ShortDescription
        {
            get
            {
                return _shortDescription ??
                       (AccountNumber.HasValue ? $"{AccountNumber.Value}" : ArticleGroupDescription);
            }
            set { _shortDescription = value; }
        }

        private string _linkDescription = null;
        [ReadOnly(true)]
        public string LinkDescription
        {
            get
            {
                return _linkDescription ?? (LedgerTagId.HasValue
                           ? LedgerTagDescription
                           :
                           ArticleGroupId.HasValue
                               ?
                               $"{ArticleGroupDescription}, {LedgerAccount?.GetLocalizedConstant()}"
                               : string.Empty);
            }
            set { _linkDescription = value; }
        }

        private string _shortLedgerTagDescription = null;
        [ReadOnly(true)]
        public string ShortLedgerTagDescription
        {
            get { return _shortLedgerTagDescription ?? (LedgerTagNumber?.ToString() ?? LedgerTagDescription); }
            set { _shortLedgerTagDescription = value; }
        }

    }
}