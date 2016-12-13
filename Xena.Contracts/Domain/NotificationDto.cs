using System;

namespace Xena.Contracts.Domain
{
    public class NotificationDto : IHasIdDto
    {
        public long? Id { get; set; }
        public long ReferenceId { get; set; }
        public string NotificationType { get; set; }
        public string Description { get; set; }
        public long? FiscalSetupId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long? UserId { get; set; }
    }
}