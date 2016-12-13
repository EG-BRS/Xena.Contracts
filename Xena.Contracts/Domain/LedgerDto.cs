namespace Xena.Contracts.Domain
{
    public class LedgerDto : EntityDto
    {
        public string Description { get; set; }
        public long? FiscalPeriodId { get; set; }
        public bool IsBookkeeping { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }
    }
}