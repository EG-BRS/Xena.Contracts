namespace Xena.Contracts.Helpers
{
    public class LedgerAccountFilterData
    {
        public long? DepartmentId { get; set; }
        public long? BearerId { get; set; }
        public long? PurposeId { get; set; }
        public string DepartmentDescription { get; set; }
        public string BearerDescription { get; set; }
        public string PurposeDescription { get; set; }
        public string LedgerAccount { get; set; }
    }
}