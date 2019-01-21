namespace Xena.Contracts.Search
{
    public class DocumentSearchIndex
    {
        public long Id { get; set; }
        public long[] FiscalSetupIds { get; set; }
        public long[] UserIds { get; set; }
        public string Description { get; set; }
        public string DocumentContent { get; set; }
        public string FileName { get; set; }
    }
}