using System.ComponentModel;

namespace Xena.Contracts.Domain
{
    public class ImportVatLineDraftDto : EntityDto
    {
        public virtual string Reference { get; set; }
        public virtual string ImportVatLineType { get; set; }
        public virtual decimal Amount { get; set; }
        public virtual int FiscalDateDays { get; set; }
        public virtual long? ArticleGroupId { get; set; }
        public virtual long? LedgerTagId { get; set; }

        //Convinience properties
        [ReadOnly(true)]
        public string ArticleGroupDescription { get; set; }
        [ReadOnly(true)]
        public int? LedgerTagNumber { get; set; }
        [ReadOnly(true)]
        public string LedgerTagDescription { get; set; }
    }
}