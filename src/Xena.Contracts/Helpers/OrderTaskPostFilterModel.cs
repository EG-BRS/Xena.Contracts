namespace Xena.Contracts.Helpers
{
    public class OrderTaskPostFilterModel
    {
        public long[] OrderTaskIds { get; set; }
        public long?[] CostTypeIds { get; set; }
        public int? FiscalDateFrom { get; set; }
        public int? FiscalDateTo { get; set; }
        public bool IncludeTransferred { get; set; }
    }
}