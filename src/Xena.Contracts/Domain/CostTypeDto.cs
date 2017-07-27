

namespace Xena.Contracts.Domain
{
    public class CostTypeDto : EntityDto
    {
        public long? Id { get; set; }
        public int Version { get; set; }
        public bool IsDeactivated { get; set; }
        public long FiscalSetupId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public long DefaultMargin { get; set; }
        public long DefaultArticleGroupId { get; set; }
        public string DefaultArticleGroupDescription { get; set; }
    }
}
