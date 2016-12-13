namespace Xena.Contracts.Domain
{
    public class ArticleVariantDto : EntityDto
    {
        public long ArticleId { get; set; }
        public bool IsPossible { get; set; }
        public string Description { get; set; }
        public string Abbreviation { get; set; }

        public string VariantDescription
        {
            get { return string.Format("{0} - {1}", Abbreviation, Description); }
        }
    }
}