using System.ComponentModel;
using Xena.Contracts.Domain;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Helpers
{
    public class AvailableDefaultReportLayoutDto : IHasIdDto
    {
        public long? Id { get; protected set; }
        public string Name { get; set; }
        public string Group { get; set; }
        private string _groupTranslated = null;
        [ReadOnly(true)]
        public string GroupTranslated
        {
            get { return _groupTranslated ?? Group.GetLocalizedReportName(); }
            set { _groupTranslated = value; }
        }
        public long ProviderId { get; protected set; }
    }
}