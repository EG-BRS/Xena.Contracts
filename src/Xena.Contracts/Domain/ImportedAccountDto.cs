

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
        public string MappedLedgerTagDescription { get; set; }
        public int? MappedLedgerTagNumber { get; set; }
        public string MappedVatAbbreviation { get; set; }
        public string MappedVatDescription { get; set; }

        public string LedgerAccountTranslated
        { get; set; }

    }
}