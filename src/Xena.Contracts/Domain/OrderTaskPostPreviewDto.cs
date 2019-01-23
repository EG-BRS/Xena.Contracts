using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Xena.Contracts.Domain
{
    public class OrderTaskPostPreviewDto : EntityDto
    {
        [Required]
        public long? VoucherPreviewId { get; set; }
        public long? CostTypeId { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public long? OrderTaskId { get; set; }
        public bool IsBookkept { get; set; }
        public int Index { get; set; }

        //Convinience properties
        [ReadOnly(true)]
        public long? ResponsibleId { get; set; }
        [ReadOnly(true)]
        public string ResponsibleName { get; set; }
        [ReadOnly(true)]
        public string CostTypeDescription { get; set; }
        [ReadOnly(true)]
        public string OrderTaskDescription { get; set; }
        [ReadOnly(true)]
        public int? OrderTaskIndex { get; set; }
        [ReadOnly(true)]
        public int? OrderNumber { get; set; }

        private string _orderTaskAbbreviation = null;
        [ReadOnly(true)]
        public string OrderTaskAbbreviation
        {
            get
            {
                return _orderTaskAbbreviation ??
                       (OrderTaskId.HasValue ? $"{OrderNumber}-{OrderTaskIndex}" : string.Empty);
            }
            set { _orderTaskAbbreviation = value; }
        }
    }
}