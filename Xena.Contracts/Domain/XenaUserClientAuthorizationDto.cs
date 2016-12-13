using System;

namespace Xena.Contracts.Domain
{
    public class XenaUserClientAuthorizationDto : IHasIdDto,IHasUserIdDto
    {
        public DateTime? ExpirationDateUtc { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public string Description { get; set; }                
        public string Scope { get; set; }
        public long? Id { get; set; }
        public long UserId { get; set; }
        public string Name { get; set; }
    }
}