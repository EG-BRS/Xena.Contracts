namespace Xena.Contracts.Helpers
{
    public class PostingManualImportData
    {
        public int FiscalDateDays { get; set; }
        public int VoucherNumber { get; set; }
        public long AccountId { get; set; }
        public string AccountNumber { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} ", VoucherNumber, Description);
        }
    }
}