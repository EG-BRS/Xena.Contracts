using System.ComponentModel;

namespace Xena.Contracts.Domain
{
    public class DiscountCodeDto : EntityDto
    {
        public string Description { get; set; }
        [ReadOnly(true)]
        public string Code { get; set; }
        public int ExpirationDateDays { get; set; }
        public long? ReferenceFiscalSetupId { get; set; }
        public string ReferenceFiscalSetupName { get; set; }
        public int LastNotificationMailSentDateDays { get; set; }
    }
}