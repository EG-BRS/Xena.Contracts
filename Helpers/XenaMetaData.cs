namespace Xena.Contracts.Helpers
{
    public class XenaMetaData
    {
        public string _id { get; set; }
        public long? FiscalSetupId { get; set; }
        public long? EntityId { get; set; }
        public string EntityType { get; set; }
        public long? XenaAppId { get; set; }
        public object Data { get; set; }
    }
} 