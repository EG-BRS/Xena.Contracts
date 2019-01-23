namespace Xena.Contracts.Domain
{
    public class DiscountCodeDto : EntityDto
    {
        public string Description { get; set; }
        public string Code { get; protected set; }
        public int ExpirationDateDays { get; set; }
        public long? ReferenceFiscalSetupId { get; set; }
        public string ReferenceFiscalSetupName { get; set; }
        public int LastNotificationMailSentDateDays { get; set; }
    }
}