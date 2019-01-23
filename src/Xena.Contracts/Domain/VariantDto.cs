using System.ComponentModel;

namespace Xena.Contracts.Domain
{
    public class VariantDto:EntityDto
    {
        public string Description { get; set; }
        public string Abbreviation { get; set; }
        public long VariantRangeId { get; set; }

        private string _variantDescription = null;
        [ReadOnly(true)]
        public string VariantDescription
        {
            get { return _variantDescription ?? (string.Format("{0} - {1}", Abbreviation, Description)); }
            set { _variantDescription = value; }
        }
    }
}