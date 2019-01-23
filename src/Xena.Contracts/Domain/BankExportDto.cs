using System.ComponentModel;

namespace Xena.Contracts.Domain
{
    public class BankExportDto : FiscalDto, IHasIdDto
    {
        //Convinience properties
        [ReadOnly(true)]
        public long? Id { get; set; }
        [ReadOnly(true)]
        public long ResourceId { get; set; }
        [ReadOnly(true)]
        public long BankContextId { get; set; }
        [ReadOnly(true)]
        public string ResourceName { get; set; }
        [ReadOnly(true)]
        public decimal TotalAmount { get; set; }
        [ReadOnly(true)]
        public int? LastSequenceNumber { get; set; }
    }
}