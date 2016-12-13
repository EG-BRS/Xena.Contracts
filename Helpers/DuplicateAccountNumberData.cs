using Xena.Resources;

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

        public string Description
        {
            get
            {
                if (ArticleGroupId.HasValue)
                    return string.Format(UI.Domain_DuplicateAccountNumberData_AccountNumberUsedByArticleGroup, AccountNumber, ArticleGroupDescription, ArticleGroupAccount);
                if (LedgerTagId.HasValue)
                    return string.Format(UI.Domain_DuplicateAccountNumberData_AccountNumberUsedByLedgerTag, AccountNumber, LedgerTagDescription);
                if (VatId.HasValue)
                    return string.Format(UI.Domain_DuplicateAccountNumberData_AccountNumberUsedByVat, AccountNumber, VatDescription);
                return string.Empty;
            }
            
        }

        public string LedgerAccount { get; set; }
    }
}