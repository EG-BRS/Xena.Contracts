namespace Xena.Contracts.Domain
{
    public class ImportVatLineDto :TransactionalDto
    {
        public string Reference { get; set; }
        public bool HasBeenCanceled { get; set; }
        public string ImportVatLineType { get; set; }
        public decimal Amount { get; set; }
        public int FiscalDateDays { get; set; }
        public long? ArticleGroupId { get; set; }
        public string ArticleGroupDescription { get; set; }
        public long? LedgerTagId { get; set; }
        public int? LedgerTagNumber { get; set; }
        public string LedgerTagDescription { get; set; }
        public long ImportVatTransactionId { get; set; }
    }
}