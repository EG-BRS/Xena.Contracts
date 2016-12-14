namespace Xena.Contracts.Helpers
{
    public class VatSettlementData
    {
        public int VatPeriodStartDays { get; set; }
        public int VatPeriodEndDays { get; set; }
        public VatSettlementPostData[] VatSettlements { get; set; }
    }
}