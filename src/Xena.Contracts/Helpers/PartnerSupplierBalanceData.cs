namespace Xena.Contracts.Helpers
{
    public class PartnerBalanceData
    {
        public long Id{get; set; }
        public BalanceData CustomerBalance { get; set; }
        public BalanceData SupplierBalance { get; set; }
    }
}