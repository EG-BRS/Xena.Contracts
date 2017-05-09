namespace Xena.Contracts.Helpers
{
    public class DiscountCodeDto
    {
        public long? Version { get; set; }
        public bool IsDeactivated { get; set; }
        public long? FiscalSetupId { get; set; }
        public string CreatedAt { get; set; }
        public long? CreatedBy { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public string ExpirationDateDays { get; set; }
        public long? ReferenceFiscalSetupId { get; set; }
        public string ReferenceFiscalSetupName { get; set; }
        public long? Id { get; set; }
    }
}
