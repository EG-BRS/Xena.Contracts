namespace Xena.Contracts.Domain
{
    public class PrimoLedgerPostDto : EntityDto
    {
        public decimal PrimoValue { get; set; }
        public decimal Adjustment { get; set; }
        public decimal Total { get; set; }
        public string Description { get; set; }
        public long FiscalPeriodId { get; set; }
        public string LedgerAccount { get; set; }
        public string Abbreviation { get; set; }
        public long? LedgerTagId { get; set; }
        public long? VatId { get; set; }
        public DimensionsDto Dimensions { get; set; }
        public long? ArticleGroupId { get; set; }
    }
}