namespace Xena.Contracts.Domain
{
    public class PartnerVatFreeSalesData
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int AccountNumber { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public string OrgNumber { get; set; }
        public decimal PeriodAmountGoods { get; set; }
        public decimal PeriodAmountServices { get; set; }
        public decimal PeriodAmountTriangular { get; set; }
    }
}