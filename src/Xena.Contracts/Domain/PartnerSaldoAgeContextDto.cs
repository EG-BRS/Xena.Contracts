

namespace Xena.Contracts.Domain
{
    public class PartnerSaldoAgeContextDto : IHasIdDto
    {
        public long ReportSubscriptionId { get; set; }
        public long? ReportLayoutId { get; set; }
        public virtual int? AccountNumberFrom { get; set; }
        public virtual int? AccountNumberTo { get; set; }
        public virtual string ContextType { get; set; }
        public long? Id { get; set; }
        public string ReportLayoutName { get; set; }

        public string ContextTypeTranslated
        { get; set; }
    }
}