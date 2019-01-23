using System.ComponentModel;
using Xena.Common.ExtensionMethods;

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
        private string _contextTypeTranslated = null;
        [ReadOnly(true)]
        public string ContextTypeTranslated
        {
            get
            {
                return _contextTypeTranslated ??
                       (string.IsNullOrEmpty(ContextType) ? string.Empty : ContextType.GetLocalizedConstant());
            }
            set { _contextTypeTranslated = value; }
        }
    }
}