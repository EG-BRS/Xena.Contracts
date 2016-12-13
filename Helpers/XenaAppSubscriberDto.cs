using Xena.Contracts.Domain;

namespace Xena.Contracts.Helpers
{
    public class XenaAppSubscriberDto : FiscalDto,IHasIdDto
    {
        public long? Id { get; set; }
        public long XenaAppId { get; set; }
        public long ReferenceFiscalSetupId { get; set; }
        public long PartnerResourceContextId { get; set; }
        public string ResourceName { get; set; }
        public string ReferenceFiscalSetupName { get; set; }
        public int? ExpiresOnDays { get; set; }
    }
    public class XenaAppFiscalSubscriberDto : FiscalDto, IHasIdDto
    {
        public long? Id { get; set; }
        public long XenaAppId { get; set; }
        public long ReferenceFiscalSetupId { get; set; }
        public string ReferenceFiscalSetupName { get; set; }
        public int NoRessources { get; set; }
    }
}