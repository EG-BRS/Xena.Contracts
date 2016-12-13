namespace Xena.Contracts.Helpers
{
    public class AccountManualImportData
    {
        public string Description { get; set; }
        public string OriginalId { get; set; }
        public string AccountNumber { get; set; }
        public string VatAccount { get; set; }
        public string LedgerAccount { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", AccountNumber, Description);
        }
    }
}