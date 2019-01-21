namespace Xena.Contracts.Helpers
{
    public class LedgerGroupDataFilter
    {
        public LedgerGroupDataFilter()
        {
            BearerId = new long[0];
            DepartmentId = new long[0];
            PurposeId = new long[0];
        }
        public long[] BearerId { get; set; }
        public long[] DepartmentId { get; set; }
        public long[] PurposeId { get; set; }
        public string LedgerGroup { get; set; }
        public long? FiscalPeriodId { get; set; }
    }
}