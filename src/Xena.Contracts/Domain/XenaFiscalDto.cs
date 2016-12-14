namespace Xena.Contracts.Domain
{
    public class XenaFiscalDto 
    {
        public long Id { get; set; }
        public bool IsDeactivated { get; set; }
        public long FiscalSetupId { get; set; }
        public long ReferenceFiscalSetupId { get; set; }
    }
}