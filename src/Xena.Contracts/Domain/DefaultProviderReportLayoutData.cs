using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class DefaultProviderReportLayoutData : IHasIdDto
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        private string _groupTranslated = null;
        [ReadOnly(true)]
        public string GroupTranslated
        {
            get { return _groupTranslated ?? Group.GetLocalizedReportName(); }
            set { _groupTranslated = value; }
        }
        public long? ReportLayoutId { get; set; }
    }
}