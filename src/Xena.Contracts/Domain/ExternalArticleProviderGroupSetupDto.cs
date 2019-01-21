using System.ComponentModel;

namespace Xena.Contracts.Domain
{
    public class ExternalArticleProviderGroupSetupDto : EntityDto
    {
        public long ProviderId { get; set; }
        public string GroupName { get; set; }
        public long? ArticleGroupId { get; set; }
        [ReadOnly(true)]
        public string ArticleGroupDescription { get; set; }
        public decimal? Markup { get; set; }
        public decimal? Discount { get; set; }
    }
}