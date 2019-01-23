using System.ComponentModel;
using Xena.Contracts.Domain;

namespace Xena.Contracts.Helpers
{
    public class AppBundleItemDto : IHasIdDto
    {
        [ReadOnly(true)]
        public long? Id { get; set; }
        [ReadOnly(true)]
        public long BundleId { get; set; }
        [ReadOnly(true)]
        public long AppId { get; set; }
        [ReadOnly(true)]
        public long AppName { get; set; }
    }
}