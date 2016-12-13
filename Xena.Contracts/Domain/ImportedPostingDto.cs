namespace Xena.Contracts.Domain
{
    public class ImportedPostingDto : ImportedDto
    {
        public int FiscalDateDays { get; set; }
        public int  VoucherNumber { get; set; }
        public long AccountId { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }
}