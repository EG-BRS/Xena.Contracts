namespace Xena.Contracts.Search
{
    public class ProjectSearchIndex
    {
        public long Id { get; set; }
        public long FiscalSetupId { get; set; }
        public string OrderNumber { get; set; }
        public string OrderNumberSplits { get; set; }
        public string OrderTaskNumber { get; set; }
        public string OrderTaskNumberSplits { get; set; }
        public string Number { get; set; }
        public string NumberSplits { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public string PartnerAccountNumber { get; set; }
        public string PartnerName { get; set; }
        public int? ClosedDateDays { get; set; }
        public bool IsClosed { get; set; }
        public bool IsDeactivated { get; set; }
    }
}