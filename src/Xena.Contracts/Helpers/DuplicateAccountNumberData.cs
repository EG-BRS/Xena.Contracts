using System.ComponentModel;
using Xena.Common.Constants;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Helpers
{
    public class DuplicateAccountNumberData
    {
        public long? ArticleGroupId { get; set; }
        public string ArticleGroupDescription { get; set; }
        public string ArticleGroupAccount { get;set; }
        public long? LedgerTagId { get; set; }
        public int AccountNumber { get; set; }
        public string LedgerTagDescription { get; set; }
        public long? VatId { get; set; }
        public string VatAbbreviation { get; set; }
        public string VatDescription { get; set; }

        private string _description = null;
        [ReadOnly(true)]
        public string Description
        {
            get
            {
                if (_description != null)
                {
                    return _description;
                }

                if (ArticleGroupId.HasValue)
                    return string.Format(DuplicateAccountNumber.AccountNumberUsedByArticleGroup.GetLocalizedConstant(), AccountNumber, ArticleGroupDescription, ArticleGroupAccount);
                if (LedgerTagId.HasValue)
                    return string.Format(DuplicateAccountNumber.AccountNumberUsedByLedgerTag.GetLocalizedConstant(), AccountNumber, LedgerTagDescription);
                if (VatId.HasValue)
                    return string.Format(DuplicateAccountNumber.AccountNumberUsedByVat.GetLocalizedConstant(), AccountNumber, VatDescription);
                return string.Empty;
            }
            set { _description = value; }

        }

        public string LedgerAccount { get; set; }
    }
}