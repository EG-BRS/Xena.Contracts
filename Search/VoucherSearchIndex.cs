namespace Xena.Contracts.Search
{
    public class VoucherSearchIndex
    {
        public long Id { get; set; }
        public long FiscalSetupId { get; set; }
        public int VoucherNumber { get; set; }
        public string Description { get; set; }
        public string LineDescriptions { get; set; }
        public string VoucherNumberRaw { get; set; }
    }
}