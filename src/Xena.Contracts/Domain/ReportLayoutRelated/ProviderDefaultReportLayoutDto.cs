using System;
using Xena.Contracts.Domain;

namespace Xena.Contracts.Helpers
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