using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class ActiveTermsCultureFullDto : IHasIdDto
    {
        public long? Id { get; set; }
        public long ProviderId { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public string Culture { get; set; }
        private string _cultureDisplayName = null;
        public string CultureDisplayName
        {
            get { return _cultureDisplayName ?? Culture.GetLocalizedCultureName(); }
            set { _cultureDisplayName = value; }
        }
        public string Markdown { get; set; }
        public long TermsId { get; set; }
    }
}