namespace Xena.Contracts.Domain
{
    public class ImportVatTransactionDto : TransactionalDto
    {
        public long? PaymentTransactionId { get; set; }
        public int? PaymentVoucherNumber { get; set; }
        public long ImportVatId { get; set; }
        public string ImportVatAbbreviation { get; set; }
        public string ImportVatDescription { get; set; }
        public string Description { get; set; }
        public bool HasBeenCanceled { get; set; }
    }
}