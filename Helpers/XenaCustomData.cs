using System;

namespace Xena.Contracts.Helpers
{
    public class XenaCustomData
    {
        public Guid _id { get; set; }
        public long? FiscalSetupId { get; set; }
        public string CustomType { get; set; }
        public long? XenaAppId { get; set; }
        public object Data { get; set; }
    }
}