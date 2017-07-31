using System;
using System.Collections.Generic;
using System.Text;
using Xena.Contracts.Domain;

namespace Xena.Contracts.Helpers
{
    public class XenaAppBundleSubscriberDto : FiscalDto, IHasIdDto
    {
        public long? Id { get; set; }
        public long XenaAppBundleId { get; set; }
        public long? UserId { get; set; }
        public long ReferenceFiscalSetupId { get; set; }
        public long PartnerResourceContextId { get; set; }
        public string ResourceName { get; set; }
        public string ResourceSenderEmail { get; set; }
        public string ReferenceFiscalSetupName { get; set; }
        public int? ExpiresOnDays { get; set; }
    }
}
