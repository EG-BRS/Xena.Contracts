using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class SettledPartnerPostDto:IHasIdDto
    {
        public long? Id { get; set; }
        public int VoucherNumber { get; set; }
        public string PostType { get; set; }
        private string _postTypeTranslated = null;
        [ReadOnly(true)]
        public string PostTypeTranslated
        {
            get
            {
                return _postTypeTranslated ??
                       (string.IsNullOrEmpty(PostType) ? string.Empty : PostType.GetLocalizedConstant());
            }
            set { _postTypeTranslated = value; }
        }
    }
}