namespace Xena.Contracts.Domain
{
    public class ProjectDto : EntityDto
    {
        public int? ClosedDateDays { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public long? ProjectStatusId { get; set; }
        public string ProjectStatusDescription { get; set; }
        public string ProjectStatusColor { get; set; }
        public long? PartnerId { get; set; }
        public int? PartnerAccountNumber { get; set; }
        public string PartnerName { get; set; }
        public long? ResponsibleId { get; set; }
        public string ResponsibleName { get; set; }
        public long? ProjectGroupId { get; set; }
        public string ProjectGroupDescription { get; set; }
        public decimal? ProjectGroupMarginTarget { get; set; }
    }
}