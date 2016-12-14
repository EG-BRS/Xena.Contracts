namespace Xena.Contracts.Domain
{
    public class OrderArticleReservationDto : EntityDto
    {
        public long OrderId { get; set; }//
        public int OrderNumber { get; set; }
        public long ArticleId { get; set; }//
        public long ArticleVariantId { get; set; }//
        public long LocationId { get; set; }//
        public string LocationAbbreviation { get; set; }
        public  decimal AmountReserved { get;  set; }//
        public  decimal QuantityReserved { get;  set; }//
        public string OrderName { get; set; }
    }
}