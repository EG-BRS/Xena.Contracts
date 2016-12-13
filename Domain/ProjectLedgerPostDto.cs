namespace Xena.Contracts.Domain
{
    public class ProjectLedgerPostDto : EntityDto
    {
        public long? ProjectId { get; set; }
        public int? ProjectNumber { get; set; }
        public string ProjectDescription { get; set; }
        public long? ResourceId { get; set; }
        public string ResourceName { get; set; }
        public long ProjectLedgerId { get; protected set; }
        public long? ProjectPostTypeId { get; set; }
        public string ProjectPostTypeDescription { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string CurrencyAbbreviation { get; set; }
    }
}