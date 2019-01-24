using System.ComponentModel;
using Xena.Contracts.Domain;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Helpers
{
    public class AvailableDefaultReportLayoutDto : IHasIdDto
    {
        [ReadOnly(true)]
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
        [ReadOnly(true)]
        public long ProviderId { get; set; }
    }
}