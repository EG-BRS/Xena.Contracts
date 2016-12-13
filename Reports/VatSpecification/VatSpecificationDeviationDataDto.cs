namespace Xena.Contracts.Reports.VatSpecification
{
    public class VatSpecificationDeviationDataDto
    {
        public string DetailType { get; set; }
        public string Description { get; set; }
        public int VoucherNumber { get; set; }
        public decimal Total { get; set; }
        public decimal VatAmount { get; set; }
        public long? VatId { get; set; }
    }
}