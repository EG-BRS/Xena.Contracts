using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class ImportedAccountDto : ImportedDto
    {
        public string OriginalId { get; set; }
        public string Description { get; set; }
        public string AccountNumber { get; set; }
        public string LedgerAccount { get; set; }
        public int? StartingNumber { get; set; }
        public long? VatId { get; set; }
        public string VatAccount { get; set; }
        public bool CanHavePosts { get; set; }
        public long? MappedLedgerTagId { get; set; }
        public long? MappedVatId { get; set; }
        public int? MappedLedgerTagNumber { get; set; }

        //Convinience properties
        [ReadOnly(true)]
        public string MappedLedgerTagDescription { get; set; }
        [ReadOnly(true)]
        public string MappedVatAbbreviation { get; set; }
        [ReadOnly(true)]
        public string MappedVatDescription { get; set; }

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
    }
}