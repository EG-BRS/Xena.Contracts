using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Xena.Contracts.Domain
{
    public class ArticleVariantDto : EntityDto
    {
        [Required]
        public long ArticleId { get; set; }
        public bool IsPossible { get; set; }
        [Required]
        [StringLength(255,MinimumLength = 1)]
        public string Description { get; set; }
        [Required]
        [StringLength(255,MinimumLength = 1)]
        public string Abbreviation { get; set; }

        //Convinience properties
        private string _variantDescription;
        [ReadOnly(true)]
        public string VariantDescription
        {
            get { return _variantDescription ?? $"{Abbreviation} - {Description}"; }
            set { _variantDescription = value; }
        }
    }
}