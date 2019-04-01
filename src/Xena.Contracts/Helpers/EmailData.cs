namespace Xena.Contracts.Helpers
{
    public class EmailData
    {
        public string Subject { get; set; }
        public string BodyText { get; set; }
        public string ToAddresses { get; set; }
        public string CCAddresses { get; set; }
        public long[] DocumentIds { get; set; }
    }
}