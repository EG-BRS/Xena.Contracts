namespace Xena.Contracts.Helpers
{
    public class VatReconciliationTotalData
    {
        private decimal? _differenceAmount;
        public long? VatId { get; set; }
        public string VatDescription { get; set; }
        public string VatAbbreviation { get; set; }
        public decimal Basis { get; set; }
        public decimal VatAmount { get; set; }
        public decimal ExpectedVatAmount { get; set; }
        public decimal DifferenceAmount
        {
            get => _differenceAmount ?? VatAmount - ExpectedVatAmount;
            set => _differenceAmount = value;
        }
    }
}