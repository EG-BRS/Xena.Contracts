namespace Xena.Contracts.Helpers
{
    public class ResourceInboxData
    {
        public long? Id { get; set; }
        public string ResourceName { get; set; }
        public int ParkedCount { get; set; }
        public int TotalCount { get; set; }
    }
}