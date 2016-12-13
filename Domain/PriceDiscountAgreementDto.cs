namespace Xena.Contracts.Domain
{
    public class PriceDiscountAgreementDto : EntityDto
    {
        public long? ArticleGroupId { get; set; }
        public long? ArticleId { get; set; }
        public string ArticleNumber { get; set; }
        public string ArticleDescription { get; set; }
        public string ArticleGroupDescription { get; set; }
        public string Description { get; set; }
        public int? ValidFromDays { get; set; }
        public int? ValidToDays { get; set; }
        public long? CustomerContextId { get; set; }
        public long? PartnerId { get; set; }
        public string PartnerName { get; set; }
        public int? PartnerAccountNumber { get; set; }
        public long? PriceGroupId { get; set; }
        public string PriceGroupDescription { get; set; }
        public decimal Discount { get; set; }
    }
}