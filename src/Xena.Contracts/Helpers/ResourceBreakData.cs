using Xena.Contracts.Domain;

namespace Xena.Contracts.Helpers
{
    public class ResourceBreakData
    {
        public long ResourceId { get; set; }
        public BreakSetupDto[] Breaks { get; set; }
    }
}