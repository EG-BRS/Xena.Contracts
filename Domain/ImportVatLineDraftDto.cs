namespace Xena.Contracts.Domain
{
    public class ImportVatLineDraftDto : EntityDto
    {
        public virtual string Reference { get; set; }
        public virtual string ImportVatLineType { get; set; }
        public virtual decimal Amount { get; set; }
        public virtual int FiscalDateDays { get; set; }
        public virtual long? ArticleGroupId { get; set; }
        public string ArticleGroupDescription { get; set; }
        public virtual long? LedgerTagId { get; set; }
        public int? LedgerTagNumber { get; set; }
        public string LedgerTagDescription { get; set; }
    }
}