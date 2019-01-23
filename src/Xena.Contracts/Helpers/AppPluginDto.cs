using System.ComponentModel;
using Xena.Contracts.Domain;

namespace Xena.Contracts.Helpers
{
    public class AppPluginDto : IHasIdDto
    {
        [ReadOnly(true)]
        public long? Id { get; set; }
        [ReadOnly(true)]
        public string Title { get; set; }
        [ReadOnly(true)]
        public string IconCssClass { get; set; }
        [ReadOnly(true)]
        public int? Index { get; set; }
        [ReadOnly(true)]
        public string PluginPlacement { get; set; }
        [ReadOnly(true)]
        public string PluginType { get; set; }
        [ReadOnly(true)]
        public string ExternalUri { get; set; }
        [ReadOnly(true)]
        public long AppId { get; set; }
        [ReadOnly(true)]
        public long? ParentPluginId { get; set; }
    }
}