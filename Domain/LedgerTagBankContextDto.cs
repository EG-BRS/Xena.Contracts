namespace Xena.Contracts.Domain
{
    public class LedgerTagBankContextDto : EntityDto
    {
        public long LedgerTagId { get; set; }
        public string LedgerTagDescription { get; set; }
        public int? LedgerTagNumber { get; set; }
    }
}