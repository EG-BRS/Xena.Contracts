using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class PartnerSaldoContextDto : IHasIdDto
    {
        public long ReportSubscriptionId { get; set; }
        public long? ReportLayoutId { get; set; }
        public virtual int? AccountNumberFrom { get; set; }
        public virtual int? AccountNumberTo { get; set; }
        public virtual decimal? SaldoFrom { get; set; }
        public virtual decimal? SaldoTo { get; set; }
        public virtual string ContextType { get; set; }
        public long? Id { get; set; }
        public string ReportLayoutName { get; set; }

        private string _contextTypeTypeTranslated = null;
        [ReadOnly(true)]
        public string ContextTypeTypeTranslated
        {
            get
            {
                return _contextTypeTypeTranslated ?? (string.IsNullOrEmpty(ContextType)
                           ? string.Empty
                           : ContextType.GetLocalizedConstant());
            }
            set { _contextTypeTypeTranslated = value; }
        }
    }
}