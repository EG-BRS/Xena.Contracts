using System.ComponentModel;
using Xena.Contracts.Domain;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Helpers
{
    public class InstalledAppDto : IHasIdDto
    {
        [ReadOnly(true)]
        public long? Id { get; set; }
        [ReadOnly(true)]
        public long AppId { get; set; }
        [ReadOnly(true)]
        public long ResourceId { get; set; }
        [ReadOnly(true)]
        public string Name { get; set; }
        [ReadOnly(true)]
        public string Description { get; set; }
        [ReadOnly(true)]
        public string ApplicationVisibility { get; set; }

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