using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Xena.Contracts.Domain
{
    public class BarCodeDto:EntityDto
    {
        public BarCodeDto()
        {
            Quantity = 1m;
        }
        [Required]
        [StringLength(255)]
        public string EANNumber { get; set; }
        [Required]
        public long ArticleId { get; set; }
        [Range(0,9999999999999)]
        public decimal Quantity { get; set; }
        //Convinience properties
        [ReadOnly(true)]
        public string ArticleNumber { get; set; }
        [ReadOnly(true)]
        public string ArticleDescription { get; set; }
    }
}