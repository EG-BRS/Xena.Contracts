

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

        public string Description { get; set; }

        public string LedgerAccount { get; set; }
    }
}