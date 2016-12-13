namespace Xena.Contracts.Helpers
{
    public class ArticleGroupManualImportData
    {
        public string Description { get; set; }
        public string OriginalId { get; set; }

        public override string ToString()
        {
            return Description;
        }
    }
}