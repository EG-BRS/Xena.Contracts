using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class TermsCultureDto : EntityDto
    {
        [Required]
        [StringLength(255)]
        public string Description { get; set; }
        public string Details { get; set; }
        public string Culture { get; set; }
        public string Markdown { get; set; }
        public long TermsId { get; set; }
        private string _cultureDisplayName = null;
        [ReadOnly(true)]
        public string CultureDisplayName
        {
            get { return _cultureDisplayName ?? Culture.GetLocalizedCultureName(); }
            set { _cultureDisplayName = value; }
        }
    }
}