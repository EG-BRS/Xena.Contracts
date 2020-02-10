using System;

namespace Xena.Contracts.Domain
{
    public class ProviderDefaultReportLayoutDto : IHasIdDto
    {
        public long? Id { get; set; }
        public string Group { get; set; }
        public string Name { get; set; }
        public long ProviderReportLayoutId { get; set; }
        public long ProviderId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}