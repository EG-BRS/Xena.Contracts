namespace Xena.Contracts.Helpers
{
    public class SaveResult
    {
        public long AssignedId { get; set; }
        public long StatusCode { get; set; }
        public string[] Messages { get; set; }
        public bool Success { get; set; }
    }
}
