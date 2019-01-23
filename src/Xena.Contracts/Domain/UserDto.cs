using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class UserDto : IHasIdDto
    {
        public long? Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Culture { get; set; }
        public bool IsXenaSupporter { get; set; }
        public long? ProviderId { get; set; }

        private string _cultureDisplayName = null;
        [ReadOnly(true)]
        public string CultureDisplayName
        {
            get { return _cultureDisplayName ?? Culture.GetLocalizedCultureName(); }
            set { _cultureDisplayName = value; }
        }
    }
} 