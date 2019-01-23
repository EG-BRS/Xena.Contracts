using System.ComponentModel;
using Xena.Contracts.Domain;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Helpers
{
    public class InstalledAppDto : IHasIdDto
    {
        public long? Id { get; protected set; }
        public long AppId { get; protected set; }
        public long ResourceId { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public string ApplicationVisibility { get; protected set; }

        private string _applicationVisibilityTranslated = null;
        [ReadOnly(true)]
        public string ApplicationVisibilityTranslated
        {
            get
            {
                return _applicationVisibilityTranslated ?? (string.IsNullOrEmpty(ApplicationVisibility)
                           ? string.Empty
                           : ApplicationVisibility.GetLocalizedConstant());
            }
            set { _applicationVisibilityTranslated = value; }
        }
    }
}