using System.ComponentModel;

namespace Xena.Contracts.Domain
{
    public class ImportVatTransactionDto : TransactionalDto
    {
        public long? PaymentTransactionId { get; set; }
        public int? PaymentVoucherNumber { get; set; }
        public long ImportVatId { get; set; }
        public string Description { get; set; }
        public bool HasBeenCanceled { get; set; }

        //Convinience properties
        [ReadOnly(true)]
        public string ImportVatAbbreviation { get; set; }
        [ReadOnly(true)]
        public string ImportVatDescription { get; set; }
    }
}